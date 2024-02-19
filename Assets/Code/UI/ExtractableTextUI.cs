#pragma warning disable 0649
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sirenix.Utilities;
using UnityEngine.UIElements;

public class ExtractableTextUI : VisualElement{
    static List<(string tag, string text)> ParseText(string text){
        List<(string, string)> extracted = new();
        bool isTagText = false;
        bool isTextMode = true;
        bool isEscaped = false;
        var currentTag = new StringBuilder();
        var currentText = new StringBuilder();
        for(var i = 0; i < text.Count(); i++){
            var c = text[i];
            if(!isEscaped && c == '\\'){
                isEscaped = true;
                continue;
            }
            if(isEscaped){
                currentText.Append(c);
                isEscaped = false;
                continue;
            }
            if(!isTagText && c == '[' && i + 1 < text.Count() && text[i + 1] == '['){
                if(currentText.Length > 0){
                    extracted.Add((currentTag.ToString(), currentText.ToString()));
                    currentText.Clear();
                    currentTag.Clear();
                }
                isTagText = true;
                isTextMode = false;
                i++;
                continue;
            }
            if(isTagText && c == ']' && i + 1 < text.Count() && text[i + 1] == ']'){
                isTextMode = true;
                i++;
                continue;
            }
            if(isTagText && c == '[' && i + 2 < text.Count() && text[i + 1] == '/' && text[i + 2] == ']'){
                i += 2;
                extracted.Add((currentTag.ToString(), currentText.ToString()));
                currentText.Clear();
                currentTag.Clear();
                isTagText = false;
                continue;
            }
            if(isTextMode){
                currentText.Append(c);
            }else{
                currentTag.Append(c);
            }
        }
        if(currentText.Length > 0){
            extracted.Add((currentTag.ToString(), currentText.ToString()));
        }
        return extracted;
    }
    public static ExtractableTextUI FromExtractableText(ExtractableText extractableText){
        var ui = new ExtractableTextUI();
        var text = ParseText(extractableText.Text);
        text.ForEach(el => {
            if(el.tag == ""){
                var label = new Label(el.text);
                ui.Add(label);
            }else{
                var data = extractableText.DossierInfo.First(d => d.Key == el.tag) ?? throw new Exception($"No dossier info found for tag {el.tag}");
                Button button = new() {
                    text = el.text
                };
                button.RegisterCallback<MouseDownEvent>(e =>{
                    DossierManager.ExtracctedData(extractableText.ID, el.tag);
                });
            }
        });
        return ui;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LerpMotion {
    public static MotionControler MakeLerpController(Vector3 start, Vector3 end, float duration, System.Action endAction){
        float elapsed = 0;
        return new() {
            Mode = ControlMode.Lerp,
            LockView = true,
            LockMode = CursorLockMode.Locked,
            UseWorldMovement = false,
            Start = ()=>{
                Debug.Log("Lerp started");
            },
            Update = (delta) => {
                elapsed += delta;
                if (elapsed >= duration) {
                    endAction();
                }
                Player.T.transform.position = Vector3.Lerp(start, end, elapsed / duration);
            }
        };
    }
}

//Maya ASCII 2022 scene
//Name: hub_greyboc.ma
//Last modified: Mon, Mar 04, 2024 04:36:09 PM
//Codeset: 1252
requires maya "2022";
requires "mtoa" "4.2.1";
currentUnit -l meter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2022";
fileInfo "version" "2022";
fileInfo "cutIdentifier" "202102181415-29bfc1879c";
fileInfo "osv" "Windows 10 Enterprise v2009 (Build: 22621)";
fileInfo "UUID" "9CA98F29-487C-EBC5-A2E2-3BB074EB045C";
createNode transform -s -n "persp";
	rename -uid "74691512-4F06-5EC7-2B63-7DBBEA346C0D";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 47.246274686234237 43.910209261350872 -31.569131584347197 ;
	setAttr ".r" -type "double3" -38.138352727695306 6244.9999999958109 0 ;
createNode camera -s -n "perspShape" -p "persp";
	rename -uid "636F169E-4BAD-ABA5-C841-B8A0DDE3C447";
	setAttr -k off ".v" no;
	setAttr ".fl" 34.999999999999993;
	setAttr ".fcp" 100000;
	setAttr ".fd" 0.05;
	setAttr ".coi" 79.333425694751043;
	setAttr ".ow" 0.1;
	setAttr ".imn" -type "string" "persp";
	setAttr ".den" -type "string" "persp_depth";
	setAttr ".man" -type "string" "persp_mask";
	setAttr ".tp" -type "double3" 171.6426157335774 50 -401.63361971295211 ;
	setAttr ".hc" -type "string" "viewSet -p %camera";
	setAttr ".ai_translator" -type "string" "perspective";
createNode transform -s -n "top";
	rename -uid "DDE15CE6-40C0-49D1-94E5-53A33EDC9677";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 0 10.001000000000001 0 ;
	setAttr ".r" -type "double3" -90 0 0 ;
createNode camera -s -n "topShape" -p "top";
	rename -uid "B2887888-4D93-5035-74F4-75A334B774B9";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".ncp" 0.001;
	setAttr ".fcp" 100;
	setAttr ".fd" 0.05;
	setAttr ".coi" 10.001000000000001;
	setAttr ".ow" 0.3;
	setAttr ".imn" -type "string" "top";
	setAttr ".den" -type "string" "top_depth";
	setAttr ".man" -type "string" "top_mask";
	setAttr ".hc" -type "string" "viewSet -t %camera";
	setAttr ".o" yes;
	setAttr ".ai_translator" -type "string" "orthographic";
createNode transform -s -n "front";
	rename -uid "EAE72406-42A2-EEC9-AC2B-A094D25C8C06";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 0 0 10.001000000000001 ;
createNode camera -s -n "frontShape" -p "front";
	rename -uid "75085DA7-4BE5-6B47-598C-11B4C186A58A";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".ncp" 0.001;
	setAttr ".fcp" 100;
	setAttr ".fd" 0.05;
	setAttr ".coi" 10.001000000000001;
	setAttr ".ow" 0.3;
	setAttr ".imn" -type "string" "front";
	setAttr ".den" -type "string" "front_depth";
	setAttr ".man" -type "string" "front_mask";
	setAttr ".hc" -type "string" "viewSet -f %camera";
	setAttr ".o" yes;
	setAttr ".ai_translator" -type "string" "orthographic";
createNode transform -s -n "side";
	rename -uid "AAED7E91-48BF-1B91-1CCE-D794A3B274CB";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 10.001000000000001 0 0 ;
	setAttr ".r" -type "double3" 0 90 0 ;
createNode camera -s -n "sideShape" -p "side";
	rename -uid "93391B9F-457A-2864-FC5D-0AAE762978A0";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".ncp" 0.001;
	setAttr ".fcp" 100;
	setAttr ".fd" 0.05;
	setAttr ".coi" 10.001000000000001;
	setAttr ".ow" 0.3;
	setAttr ".imn" -type "string" "side";
	setAttr ".den" -type "string" "side_depth";
	setAttr ".man" -type "string" "side_mask";
	setAttr ".hc" -type "string" "viewSet -s %camera";
	setAttr ".o" yes;
	setAttr ".ai_translator" -type "string" "orthographic";
createNode transform -n "pPlane1";
	rename -uid "7C058FF4-4AF9-6A9B-63A1-ADACD356D9CE";
	setAttr ".s" -type "double3" 8 1 8 ;
createNode mesh -n "pPlaneShape1" -p "pPlane1";
	rename -uid "54ACE093-4BFE-3BC6-A79A-99B86F848B2C";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 10 ".pt[0:9]" -type "float3"  0.12524968 0 0 -0.12524968 
		0 0 0.12524968 0 0 -0.12524968 0 0 0.12524968 0 0 -0.12524968 0 0 0 3.0517577e-07 
		0 0 3.0517577e-07 0 0 -7.6293946e-07 0 0 -7.6293946e-07 0;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pPlane2";
	rename -uid "814AF21C-4F32-8CF6-8B3E-3E9FCEC61E80";
	setAttr ".t" -type "double3" 10.472578876111728 0.61275989234802641 -11.974120232440841 ;
	setAttr ".s" -type "double3" 5.0924765500729263 5.0924765500729263 5.0924765500729263 ;
createNode mesh -n "pPlaneShape2" -p "pPlane2";
	rename -uid "E5DF04C5-4E60-DA8A-85A5-D5ABC0168F28";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 4 ".pt[4:7]" -type "float3"  0 0.020188408 0 0 0.020188408 
		0 0 0.020188408 0 0 0.020188408 0;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCylinder1";
	rename -uid "EA0A07A7-48BE-26A7-C40D-03BCBE58C667";
	setAttr ".t" -type "double3" -11.046500505920299 0.5 17.527866866787477 ;
	setAttr ".s" -type "double3" 0.25 0.5 0.25 ;
createNode mesh -n "pCylinderShape1" -p "pCylinder1";
	rename -uid "2B3C72DB-4E04-A16A-B2C7-B2AD92B814A7";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube1";
	rename -uid "808F09D5-4B01-B036-9E38-00A76FDD6063";
	setAttr ".t" -type "double3" 7.2563981840949134 0 -9.0529083953408414 ;
	setAttr ".s" -type "double3" 6.2742423488028001 8.7428001542445202 6.2742423488028001 ;
createNode mesh -n "pCubeShape1" -p "pCube1";
	rename -uid "890891DE-4289-C7EF-6871-A9B316087D50";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.36739948391914368 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 25 ".pt";
	setAttr ".pt[1]" -type "float3" 0.14327949 0 0 ;
	setAttr ".pt[3]" -type "float3" 0.14327949 0 0 ;
	setAttr ".pt[5]" -type "float3" 0.14327949 0 0 ;
	setAttr ".pt[7]" -type "float3" 0.14327949 0 0 ;
	setAttr ".pt[8]" -type "float3" 0.14327949 0 0 ;
	setAttr ".pt[11]" -type "float3" 0.14327949 0 0 ;
	setAttr ".pt[12]" -type "float3" 0 0.030436082 0 ;
	setAttr ".pt[13]" -type "float3" 0.14327949 0.030436082 0 ;
	setAttr ".pt[14]" -type "float3" 0.14327949 0.030436082 0 ;
	setAttr ".pt[15]" -type "float3" 0 0.030436082 0 ;
	setAttr ".pt[16]" -type "float3" 0 0.030436082 0 ;
	setAttr ".pt[19]" -type "float3" 0.14327949 0 0 ;
	setAttr ".pt[20]" -type "float3" 0.14327949 0 0 ;
	setAttr ".pt[21]" -type "float3" 0.14327949 0.030436082 0 ;
	setAttr ".pt[22]" -type "float3" 0 0.030436082 0.097320281 ;
	setAttr ".pt[23]" -type "float3" 0 0 0.097320281 ;
	setAttr ".pt[24]" -type "float3" 0 0 0.097320281 ;
	setAttr ".pt[25]" -type "float3" 0.14327949 0 0.097320281 ;
	setAttr ".pt[26]" -type "float3" 0.14327949 0 0.097320281 ;
	setAttr ".pt[27]" -type "float3" 0.14327949 0.030436082 0.097320281 ;
	setAttr ".pt[28]" -type "float3" 0 0.030436082 0 ;
	setAttr ".pt[29]" -type "float3" 0.14327949 0.030436082 0 ;
	setAttr ".pt[30]" -type "float3" 0.14327949 0.030436082 0 ;
	setAttr ".pt[31]" -type "float3" 0 0.030436082 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCylinder2";
	rename -uid "55C8C1ED-4055-725C-F7C1-90A7FBAA14CC";
	setAttr ".t" -type "double3" 6.4686369467710527 6.4603070935397326 -11.803099412116586 ;
	setAttr ".s" -type "double3" 0.25 0.5 0.25 ;
createNode mesh -n "pCylinderShape2" -p "pCylinder2";
	rename -uid "83AB752C-4068-BC43-83EC-358165643C43";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 84 ".uvst[0].uvsp[0:83]" -type "float2" 0.64860266 0.10796607
		 0.62640899 0.064408496 0.59184152 0.029841021 0.54828393 0.0076473355 0.5 -7.4505806e-08
		 0.45171607 0.0076473504 0.40815851 0.029841051 0.37359107 0.064408526 0.3513974 0.1079661
		 0.34374997 0.15625 0.3513974 0.2045339 0.37359107 0.24809146 0.40815854 0.28265893
		 0.4517161 0.3048526 0.5 0.3125 0.54828387 0.3048526 0.59184146 0.28265893 0.62640893
		 0.24809146 0.6486026 0.2045339 0.65625 0.15625 0.375 0.3125 0.38749999 0.3125 0.39999998
		 0.3125 0.41249996 0.3125 0.42499995 0.3125 0.43749994 0.3125 0.44999993 0.3125 0.46249992
		 0.3125 0.4749999 0.3125 0.48749989 0.3125 0.49999988 0.3125 0.51249987 0.3125 0.52499986
		 0.3125 0.53749985 0.3125 0.54999983 0.3125 0.56249982 0.3125 0.57499981 0.3125 0.5874998
		 0.3125 0.59999979 0.3125 0.61249977 0.3125 0.62499976 0.3125 0.375 0.68843985 0.38749999
		 0.68843985 0.39999998 0.68843985 0.41249996 0.68843985 0.42499995 0.68843985 0.43749994
		 0.68843985 0.44999993 0.68843985 0.46249992 0.68843985 0.4749999 0.68843985 0.48749989
		 0.68843985 0.49999988 0.68843985 0.51249987 0.68843985 0.52499986 0.68843985 0.53749985
		 0.68843985 0.54999983 0.68843985 0.56249982 0.68843985 0.57499981 0.68843985 0.5874998
		 0.68843985 0.59999979 0.68843985 0.61249977 0.68843985 0.62499976 0.68843985 0.64860266
		 0.79546607 0.62640899 0.75190848 0.59184152 0.71734101 0.54828393 0.69514734 0.5
		 0.68749994 0.45171607 0.69514734 0.40815851 0.71734107 0.37359107 0.75190854 0.3513974
		 0.79546607 0.34374997 0.84375 0.3513974 0.89203393 0.37359107 0.93559146 0.40815854
		 0.97015893 0.4517161 0.9923526 0.5 1 0.54828387 0.9923526 0.59184146 0.97015893 0.62640893
		 0.93559146 0.6486026 0.89203393 0.65625 0.84375 0.5 0.15000001 0.5 0.83749998;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 42 ".vt[0:41]"  0.95105714 -1 -0.30901718 0.80901754 -1 -0.5877856
		 0.5877856 -1 -0.80901748 0.30901715 -1 -0.95105708 0 -1 -1.000000476837 -0.30901715 -1 -0.95105696
		 -0.58778548 -1 -0.80901736 -0.80901724 -1 -0.58778542 -0.95105672 -1 -0.30901706
		 -1.000000238419 -1 0 -0.95105672 -1 0.30901706 -0.80901718 -1 0.58778536 -0.58778536 -1 0.80901712
		 -0.30901706 -1 0.95105666 -2.9802322e-08 -1 1.000000119209 0.30901697 -1 0.9510566
		 0.58778524 -1 0.809017 0.809017 -1 0.5877853 0.95105654 -1 0.309017 1 -1 0 0.95105714 1 -0.30901718
		 0.80901754 1 -0.5877856 0.5877856 1 -0.80901748 0.30901715 1 -0.95105708 0 1 -1.000000476837
		 -0.30901715 1 -0.95105696 -0.58778548 1 -0.80901736 -0.80901724 1 -0.58778542 -0.95105672 1 -0.30901706
		 -1.000000238419 1 0 -0.95105672 1 0.30901706 -0.80901718 1 0.58778536 -0.58778536 1 0.80901712
		 -0.30901706 1 0.95105666 -2.9802322e-08 1 1.000000119209 0.30901697 1 0.9510566 0.58778524 1 0.809017
		 0.809017 1 0.5877853 0.95105654 1 0.309017 1 1 0 0 -1 0 0 1 0;
	setAttr -s 100 ".ed[0:99]"  0 1 0 1 2 0 2 3 0 3 4 0 4 5 0 5 6 0 6 7 0
		 7 8 0 8 9 0 9 10 0 10 11 0 11 12 0 12 13 0 13 14 0 14 15 0 15 16 0 16 17 0 17 18 0
		 18 19 0 19 0 0 20 21 0 21 22 0 22 23 0 23 24 0 24 25 0 25 26 0 26 27 0 27 28 0 28 29 0
		 29 30 0 30 31 0 31 32 0 32 33 0 33 34 0 34 35 0 35 36 0 36 37 0 37 38 0 38 39 0 39 20 0
		 0 20 1 1 21 1 2 22 1 3 23 1 4 24 1 5 25 1 6 26 1 7 27 1 8 28 1 9 29 1 10 30 1 11 31 1
		 12 32 1 13 33 1 14 34 1 15 35 1 16 36 1 17 37 1 18 38 1 19 39 1 40 0 1 40 1 1 40 2 1
		 40 3 1 40 4 1 40 5 1 40 6 1 40 7 1 40 8 1 40 9 1 40 10 1 40 11 1 40 12 1 40 13 1
		 40 14 1 40 15 1 40 16 1 40 17 1 40 18 1 40 19 1 20 41 1 21 41 1 22 41 1 23 41 1 24 41 1
		 25 41 1 26 41 1 27 41 1 28 41 1 29 41 1 30 41 1 31 41 1 32 41 1 33 41 1 34 41 1 35 41 1
		 36 41 1 37 41 1 38 41 1 39 41 1;
	setAttr -s 60 -ch 200 ".fc[0:59]" -type "polyFaces" 
		f 4 0 41 -21 -41
		mu 0 4 20 21 42 41
		f 4 1 42 -22 -42
		mu 0 4 21 22 43 42
		f 4 2 43 -23 -43
		mu 0 4 22 23 44 43
		f 4 3 44 -24 -44
		mu 0 4 23 24 45 44
		f 4 4 45 -25 -45
		mu 0 4 24 25 46 45
		f 4 5 46 -26 -46
		mu 0 4 25 26 47 46
		f 4 6 47 -27 -47
		mu 0 4 26 27 48 47
		f 4 7 48 -28 -48
		mu 0 4 27 28 49 48
		f 4 8 49 -29 -49
		mu 0 4 28 29 50 49
		f 4 9 50 -30 -50
		mu 0 4 29 30 51 50
		f 4 10 51 -31 -51
		mu 0 4 30 31 52 51
		f 4 11 52 -32 -52
		mu 0 4 31 32 53 52
		f 4 12 53 -33 -53
		mu 0 4 32 33 54 53
		f 4 13 54 -34 -54
		mu 0 4 33 34 55 54
		f 4 14 55 -35 -55
		mu 0 4 34 35 56 55
		f 4 15 56 -36 -56
		mu 0 4 35 36 57 56
		f 4 16 57 -37 -57
		mu 0 4 36 37 58 57
		f 4 17 58 -38 -58
		mu 0 4 37 38 59 58
		f 4 18 59 -39 -59
		mu 0 4 38 39 60 59
		f 4 19 40 -40 -60
		mu 0 4 39 40 61 60
		f 3 -1 -61 61
		mu 0 3 1 0 82
		f 3 -2 -62 62
		mu 0 3 2 1 82
		f 3 -3 -63 63
		mu 0 3 3 2 82
		f 3 -4 -64 64
		mu 0 3 4 3 82
		f 3 -5 -65 65
		mu 0 3 5 4 82
		f 3 -6 -66 66
		mu 0 3 6 5 82
		f 3 -7 -67 67
		mu 0 3 7 6 82
		f 3 -8 -68 68
		mu 0 3 8 7 82
		f 3 -9 -69 69
		mu 0 3 9 8 82
		f 3 -10 -70 70
		mu 0 3 10 9 82
		f 3 -11 -71 71
		mu 0 3 11 10 82
		f 3 -12 -72 72
		mu 0 3 12 11 82
		f 3 -13 -73 73
		mu 0 3 13 12 82
		f 3 -14 -74 74
		mu 0 3 14 13 82
		f 3 -15 -75 75
		mu 0 3 15 14 82
		f 3 -16 -76 76
		mu 0 3 16 15 82
		f 3 -17 -77 77
		mu 0 3 17 16 82
		f 3 -18 -78 78
		mu 0 3 18 17 82
		f 3 -19 -79 79
		mu 0 3 19 18 82
		f 3 -20 -80 60
		mu 0 3 0 19 82
		f 3 20 81 -81
		mu 0 3 80 79 83
		f 3 21 82 -82
		mu 0 3 79 78 83
		f 3 22 83 -83
		mu 0 3 78 77 83
		f 3 23 84 -84
		mu 0 3 77 76 83
		f 3 24 85 -85
		mu 0 3 76 75 83
		f 3 25 86 -86
		mu 0 3 75 74 83
		f 3 26 87 -87
		mu 0 3 74 73 83
		f 3 27 88 -88
		mu 0 3 73 72 83
		f 3 28 89 -89
		mu 0 3 72 71 83
		f 3 29 90 -90
		mu 0 3 71 70 83
		f 3 30 91 -91
		mu 0 3 70 69 83
		f 3 31 92 -92
		mu 0 3 69 68 83
		f 3 32 93 -93
		mu 0 3 68 67 83
		f 3 33 94 -94
		mu 0 3 67 66 83
		f 3 34 95 -95
		mu 0 3 66 65 83
		f 3 35 96 -96
		mu 0 3 65 64 83
		f 3 36 97 -97
		mu 0 3 64 63 83
		f 3 37 98 -98
		mu 0 3 63 62 83
		f 3 38 99 -99
		mu 0 3 62 81 83
		f 3 39 80 -100
		mu 0 3 81 80 83;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube2";
	rename -uid "CFC238A6-4782-2FAE-1FE9-5D8489BE354A";
	setAttr ".t" -type "double3" 12.202013214998736 0 -11.258097443217899 ;
	setAttr ".s" -type "double3" 1 8.5305638403579813 5.3789350455246145 ;
createNode mesh -n "pCubeShape2" -p "pCube2";
	rename -uid "A59AA413-41A5-ED31-0C00-5B9AD2488247";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -0.37274846 0.5 0.28659657 
		5.5627155 0.5 0.28659657 -0.37274846 0 0.28659657 5.5627155 0 0.28659657 -0.37274846 
		0 0.1456774 5.5627155 0 0.1456774 -0.37274846 0.5 0.1456774 5.5627155 0.5 0.1456774;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube3";
	rename -uid "B74A2296-4E3A-47F5-0878-588CA0B39E72";
	setAttr ".t" -type "double3" -9.7781347600461714 0 -9.5621975521059408 ;
	setAttr ".s" -type "double3" 1 8.5305638403579813 5.3789350455246145 ;
createNode mesh -n "pCubeShape3" -p "pCube3";
	rename -uid "2A3CA182-4669-1C8F-7B07-AFBC02ABE0B1";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -1.2717178 0.5 0.22306865 
		5.1050553 0.5 0.22306865 -1.2717178 -0.13143708 0.22306864 5.1050553 -0.13143708 
		0.22306864 -1.2717178 -0.13143708 -0.61134946 5.1050553 -0.13143708 -0.61134946 -1.2717178 
		0.5 -0.61134946 5.1050553 0.5 -0.61134946;
	setAttr -s 8 ".vt[0:7]"  -0.5 -0.5 0.5 0.5 -0.5 0.5 -0.5 0.5 0.5 0.5 0.5 0.5
		 -0.5 0.5 -0.5 0.5 0.5 -0.5 -0.5 -0.5 -0.5 0.5 -0.5 -0.5;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 4 5 7 6
		f 4 2 9 -4 -9
		mu 0 4 8 9 11 10
		f 4 3 11 -1 -11
		mu 0 4 12 13 15 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pPlane3";
	rename -uid "19BEA29F-4E48-3A9C-7A74-658B5D9AB2C5";
	setAttr ".t" -type "double3" -12.5254248046875 0.61275989234802641 -11.974120232440841 ;
	setAttr ".s" -type "double3" 5.0924765500729263 5.0924765500729263 5.0924765500729263 ;
	setAttr ".rp" -type "double3" -7.4745751953125028 -0.61275981605408125 7.9741196220892805 ;
	setAttr ".sp" -type "double3" -1.4677682109710377 -0.12032648752114654 1.5658628063736659 ;
	setAttr ".spt" -type "double3" -6.0068069843414644 -0.4924333285329347 6.4082568157156139 ;
createNode mesh -n "pPlaneShape3" -p "pPlane3";
	rename -uid "B2B1DC71-4C38-659D-9C1E-1E894C5FF015";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 12 ".uvst[0].uvsp[0:11]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 1 1 0 1 0 0 1 0 1 1 0 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 4 ".pt[4:7]" -type "float3"  0 0.020188408 0 0 0.020188408 
		0 0 0.020188408 0 0 0.020188408 0;
	setAttr -s 8 ".vt[0:7]"  -1.46776819 -0.12032649 1.56586277 1.8708818 -0.12032665 1.56586301
		 -1.46776819 -0.12032649 -1.57602704 1.8708818 -0.12032649 -1.5760268 -1.46776819 -0.12032649 1.56586277
		 1.8708818 -0.12032665 1.56586301 1.8708818 -0.12032649 -1.5760268 -1.46776819 -0.12032649 -1.57602704;
	setAttr -s 12 ".ed[0:11]"  0 1 0 0 2 0 1 3 0 2 3 0 0 4 0 1 5 0 4 5 0
		 3 6 0 5 6 0 2 7 0 7 6 0 4 7 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 6 8 -11 -12
		mu 0 4 8 9 10 11
		f 4 1 3 -3 -1
		mu 0 4 4 7 6 5
		f 4 0 5 -7 -5
		mu 0 4 0 1 9 8
		f 4 2 7 -9 -6
		mu 0 4 1 3 10 9
		f 4 -4 9 10 -8
		mu 0 4 3 2 11 10
		f 4 -2 4 11 -10
		mu 0 4 2 0 8 11;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pPlane4";
	rename -uid "25D7152E-4778-668E-34B3-2DA05C5D94E4";
	setAttr ".t" -type "double3" 27.4745751953125 0.61275981605408125 -3.97411962208928 ;
	setAttr ".r" -type "double3" 0 180 0 ;
	setAttr ".s" -type "double3" 5.0924765500729263 5.0924765500729263 5.0924765500729263 ;
	setAttr ".rp" -type "double3" -7.4745751953125028 -0.61275981605408125 7.9741196220892805 ;
	setAttr ".sp" -type "double3" -1.4677682109710377 -0.12032648752114654 1.5658628063736659 ;
	setAttr ".spt" -type "double3" -6.0068069843414644 -0.4924333285329347 6.4082568157156139 ;
createNode mesh -n "pPlaneShape4" -p "pPlane4";
	rename -uid "21FE3BF5-49F5-BACD-1646-B2AFA22A4C1C";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 12 ".uvst[0].uvsp[0:11]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 1 1 0 1 0 0 1 0 1 1 0 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 7 ".pt[1:7]" -type "float3"  4.5160742 0 0 0 0 -1.4320173 
		4.5160742 0 -1.4320173 0 0.020188408 0 4.5160742 0.020188408 0 4.5160742 0.020188408 
		-1.4320173 0 0.020188408 -1.4320173;
	setAttr -s 8 ".vt[0:7]"  -1.46776819 -0.12032649 1.56586277 1.8708818 -0.12032665 1.56586301
		 -1.46776819 -0.12032649 -1.57602704 1.8708818 -0.12032649 -1.5760268 -1.46776819 -0.12032649 1.56586277
		 1.8708818 -0.12032665 1.56586301 1.8708818 -0.12032649 -1.5760268 -1.46776819 -0.12032649 -1.57602704;
	setAttr -s 12 ".ed[0:11]"  0 1 0 0 2 0 1 3 0 2 3 0 0 4 0 1 5 0 4 5 0
		 3 6 0 5 6 0 2 7 0 7 6 0 4 7 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 6 8 -11 -12
		mu 0 4 8 9 10 11
		f 4 1 3 -3 -1
		mu 0 4 4 7 6 5
		f 4 0 5 -7 -5
		mu 0 4 0 1 9 8
		f 4 2 7 -9 -6
		mu 0 4 1 3 10 9
		f 4 -4 9 10 -8
		mu 0 4 3 2 11 10
		f 4 -2 4 11 -10
		mu 0 4 2 0 8 11;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube4";
	rename -uid "43364B05-4A21-371F-EDC7-3F903575E7FE";
	setAttr ".t" -type "double3" -17.799078294760481 0 -9.5621975521059408 ;
	setAttr ".s" -type "double3" 1 8.5305638403579813 5.3789350455246145 ;
createNode mesh -n "pCubeShape4" -p "pCube4";
	rename -uid "66E9665D-461A-F56A-C03A-669BE6CEBFD6";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -0.31820792 0.5 0.22306865 
		4.272459 0.5 0.22306865 -0.31820792 0.14655477 0.22306864 4.272459 0.14655477 0.22306864 
		-0.31820792 0.14655477 0.40231654 4.272459 0.14655477 0.40231654 -0.31820792 0.50000012 
		0.40231654 4.272459 0.50000012 0.40231654;
	setAttr -s 8 ".vt[0:7]"  -0.5 -0.5 0.5 0.5 -0.5 0.5 -0.5 0.5 0.5 0.5 0.5 0.5
		 -0.5 0.5 -0.5 0.5 0.5 -0.5 -0.5 -0.5 -0.5 0.5 -0.5 -0.5;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 4 5 7 6
		f 4 2 9 -4 -9
		mu 0 4 8 9 11 10
		f 4 3 11 -1 -11
		mu 0 4 12 13 15 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube5";
	rename -uid "311B9101-4C92-F341-E6BC-3CB01CB4E51B";
	setAttr ".t" -type "double3" -18.109839143254142 -4.5474735088646413e-15 -15.59510575912655 ;
	setAttr ".s" -type "double3" 0.40447497194513554 8.5305638403579813 2.8173930255811053 ;
createNode mesh -n "pCubeShape5" -p "pCube5";
	rename -uid "EAC8EF33-4B15-F480-42CC-7D8FB737B8C8";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode mesh -n "polySurfaceShape1" -p "pCube5";
	rename -uid "0BA89E23-4713-C676-562E-0F9AB01A7053";
	setAttr -k off ".v";
	setAttr ".io" yes;
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -1.2717178 0.5 0.22306865 
		5.1050553 0.5 0.22306865 -1.2717178 -0.25591543 0.22306864 5.1050553 -0.25591543 
		0.22306864 -1.2717178 -0.25591543 -0.61134946 5.1050553 -0.25591543 -0.61134946 -1.2717178 
		0.5 -0.61134946 5.1050553 0.5 -0.61134946;
	setAttr -s 8 ".vt[0:7]"  -0.5 -0.5 0.5 0.5 -0.5 0.5 -0.5 0.5 0.5 0.5 0.5 0.5
		 -0.5 0.5 -0.5 0.5 0.5 -0.5 -0.5 -0.5 -0.5 0.5 -0.5 -0.5;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 4 5 7 6
		f 4 2 9 -4 -9
		mu 0 4 8 9 11 10
		f 4 3 11 -1 -11
		mu 0 4 12 13 15 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube6";
	rename -uid "AF606B7D-458E-F3E6-B9A0-D493DA03E734";
	setAttr ".t" -type "double3" -7.610792504162414 0 11.563490711414934 ;
	setAttr ".s" -type "double3" 1 8.5305638403579813 5.3789350455246145 ;
createNode mesh -n "pCubeShape6" -p "pCube6";
	rename -uid "1734872E-434F-E696-53BA-74B62B143A92";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 11 ".pt";
	setAttr ".pt[0]" -type "float3" 0 0 -0.20803821 ;
	setAttr ".pt[1]" -type "float3" 0 0 -0.20803821 ;
	setAttr ".pt[2]" -type "float3" 0 0 -0.20803821 ;
	setAttr ".pt[3]" -type "float3" 0 0 -0.20803821 ;
	setAttr ".pt[8]" -type "float3" 0 0 -0.044658385 ;
	setAttr ".pt[9]" -type "float3" 0 0 -0.044658385 ;
	setAttr ".pt[10]" -type "float3" 0 0 -0.044658385 ;
	setAttr ".pt[11]" -type "float3" 0 0 -0.044658385 ;
	setAttr ".pt[12]" -type "float3" 0 0 -0.044658385 ;
	setAttr ".pt[13]" -type "float3" 0 0 -0.044658385 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode mesh -n "polySurfaceShape2" -p "pCube6";
	rename -uid "C727A263-4C6C-CE34-C3F4-79A389FE92AA";
	setAttr -k off ".v";
	setAttr ".io" yes;
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -4.6970916 0.5 -0.73403925 
		5.1050553 0.5 -0.73403925 -4.6970916 -0.13143708 -0.73403925 5.1050553 -0.13143708 
		-0.73403925 -4.6970916 -0.13143708 -0.61134946 5.1050553 -0.13143708 -0.61134946 
		-4.6970916 0.5 -0.61134946 5.1050553 0.5 -0.61134946;
	setAttr -s 8 ".vt[0:7]"  -0.5 -0.5 0.5 0.5 -0.5 0.5 -0.5 0.5 0.5 0.5 0.5 0.5
		 -0.5 0.5 -0.5 0.5 0.5 -0.5 -0.5 -0.5 -0.5 0.5 -0.5 -0.5;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 4 5 7 6
		f 4 2 9 -4 -9
		mu 0 4 8 9 11 10
		f 4 3 11 -1 -11
		mu 0 4 12 13 15 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube7";
	rename -uid "788DF2B8-4D2D-B862-7210-AF924DFBBFCE";
	setAttr ".t" -type "double3" -16.25873743357069 0 10.605105667544692 ;
	setAttr ".s" -type "double3" 1 8.5305638403579813 5.3789350455246145 ;
createNode mesh -n "pCubeShape7" -p "pCube7";
	rename -uid "2E293426-48E6-8BA1-BE9B-79B99FCD0C82";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -1.2717178 0.5 0.050805021 
		2.9901104 0.5 0.050805021 -1.2717178 0.40435243 0.050805002 2.9901104 0.40435243 
		0.050805002 -1.2717178 0.40435243 -0.54505092 2.9901104 0.40435243 -0.54505092 -1.2717178 
		0.5 -0.54505092 2.9901104 0.5 -0.54505092;
	setAttr -s 8 ".vt[0:7]"  -0.5 -0.5 0.5 0.5 -0.5 0.5 -0.5 0.5 0.5 0.5 0.5 0.5
		 -0.5 0.5 -0.5 0.5 0.5 -0.5 -0.5 -0.5 -0.5 0.5 -0.5 -0.5;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 4 5 7 6
		f 4 2 9 -4 -9
		mu 0 4 8 9 11 10
		f 4 3 11 -1 -11
		mu 0 4 12 13 15 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube8";
	rename -uid "B0521409-4AF2-4902-48B0-BE995DCD6565";
	setAttr ".t" -type "double3" 14.253661218025634 4.5474735088646413e-15 21.330508082568823 ;
	setAttr ".s" -type "double3" 1 8.5305638403579813 4.2789500941143732 ;
createNode mesh -n "pCubeShape8" -p "pCube8";
	rename -uid "0C540845-4838-48AC-BBD7-C2AC7D38E44F";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 1 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -8.123373 0.5 0.86598688 
		3.7376618 0.5 0.86598688 -8.123373 0.13574953 0.8659867 3.7376618 0.13574953 0.8659867 
		-8.123373 0.13574953 -0.00022584677 3.7376618 0.13574953 -0.00022584677 -8.123373 
		0.5 -0.00022584677 3.7376618 0.5 -0.00022584677;
	setAttr -s 8 ".vt[0:7]"  -0.5 -0.5 0.5 0.5 -0.5 0.5 -0.5 0.5 0.5 0.5 0.5 0.5
		 -0.5 0.5 -0.5 0.5 0.5 -0.5 -0.5 -0.5 -0.5 0.5 -0.5 -0.5;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 4 5 7 6
		f 4 2 9 -4 -9
		mu 0 4 8 9 11 10
		f 4 3 11 -1 -11
		mu 0 4 12 13 15 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube9";
	rename -uid "98D346AA-4DC1-89AD-0306-4DB3D210BA3E";
	setAttr ".t" -type "double3" 19.46911056501963 4.5474735088646413e-15 7.255922094222691 ;
	setAttr ".s" -type "double3" 0.014531397264375169 9.2790113592972752 0.11991168497494094 ;
createNode mesh -n "pCubeShape9" -p "pCube9";
	rename -uid "D30CE5C6-423A-0333-4728-4BB85D24B47B";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -3.5809948 0.5 0.050805021 
		5.1120481 0.5 0.050805021 -3.5809948 -0.090632945 0.050805002 5.1120481 -0.090632945 
		0.050805002 -3.5809948 -0.090632945 -0.16033731 5.1120481 -0.090632945 -0.16033731 
		-3.5809948 0.5 -0.16033731 5.1120481 0.5 -0.16033731;
	setAttr -s 8 ".vt[0:7]"  -0.5 -0.5 0.5 0.5 -0.5 0.5 -0.5 0.5 0.5 0.5 0.5 0.5
		 -0.5 0.5 -0.5 0.5 0.5 -0.5 -0.5 -0.5 -0.5 0.5 -0.5 -0.5;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 4 5 7 6
		f 4 2 9 -4 -9
		mu 0 4 8 9 11 10
		f 4 3 11 -1 -11
		mu 0 4 12 13 15 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube10";
	rename -uid "1D548D04-46F5-2F66-CC21-8EA8DA2841D1";
	setAttr ".t" -type "double3" 19.4993773371163 2.6701386873221349 6.1704661329054531 ;
	setAttr ".r" -type "double3" 0 90 0 ;
	setAttr ".s" -type "double3" 0.19494347279252325 11.361483405466569 0.42839586343299024 ;
createNode mesh -n "pCubeShape10" -p "pCube10";
	rename -uid "BDB9A681-460D-937E-7C3F-1694EE91F0DE";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -6.251493 0.5 0.30320805 
		5.7190762 0.5 0.30320805 -6.251493 0.019944871 0.30320805 5.7190762 0.019944871 0.30320805 
		-6.251493 0.019944871 -0.41274014 5.7190762 0.019944871 -0.41274014 -6.251493 0.5 
		-0.41274014 5.7190762 0.5 -0.41274014;
	setAttr -s 8 ".vt[0:7]"  -0.5 -0.5 0.5 0.5 -0.5 0.5 -0.5 0.5 0.5 0.5 0.5 0.5
		 -0.5 0.5 -0.5 0.5 0.5 -0.5 -0.5 -0.5 -0.5 0.5 -0.5 -0.5;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 4 5 7 6
		f 4 2 9 -4 -9
		mu 0 4 8 9 11 10
		f 4 3 11 -1 -11
		mu 0 4 12 13 15 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube11";
	rename -uid "1AD8C0AD-469B-CD21-5487-3695CD063290";
	setAttr ".t" -type "double3" 19.46911056501963 4.5474735088646413e-15 5.1985965422635436 ;
	setAttr ".s" -type "double3" 0.014531397264375169 9.2790113592972752 0.11991168497494094 ;
createNode mesh -n "pCubeShape11" -p "pCube11";
	rename -uid "07422EF1-43A4-35EB-414E-AC89DB80DC92";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -3.5809948 0.5 0.050805021 
		5.1120481 0.5 0.050805021 -3.5809948 -0.090632945 0.050805002 5.1120481 -0.090632945 
		0.050805002 -3.5809948 -0.090632945 -0.16033731 5.1120481 -0.090632945 -0.16033731 
		-3.5809948 0.5 -0.16033731 5.1120481 0.5 -0.16033731;
	setAttr -s 8 ".vt[0:7]"  -0.5 -0.5 0.5 0.5 -0.5 0.5 -0.5 0.5 0.5 0.5 0.5 0.5
		 -0.5 0.5 -0.5 0.5 0.5 -0.5 -0.5 -0.5 -0.5 0.5 -0.5 -0.5;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 4 5 7 6
		f 4 2 9 -4 -9
		mu 0 4 8 9 11 10
		f 4 3 11 -1 -11
		mu 0 4 12 13 15 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube12";
	rename -uid "E65598F3-4245-7A7C-4E7C-95B44C391E9B";
	setAttr ".t" -type "double3" 11.045080912054692 5.6553097702746582 9.8665703905579658 ;
	setAttr ".s" -type "double3" 1.3268314294767607 2.4253045074200483 7.2229875574389393 ;
createNode mesh -n "pCubeShape12" -p "pCube12";
	rename -uid "E4829D9D-4C57-FDDF-2F1C-0793BD527400";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -3.5876555 0.40433839 1.8963668 
		5.1053872 0.40433839 1.8963668 -3.5876555 -0.090632945 1.8963668 5.1053872 -0.090632945 
		1.8963668 -3.5809948 -0.090632945 0.11982868 5.1120481 -0.090632945 0.11982868 -3.5809948 
		0.40433839 0.11982868 5.1120481 0.40433839 0.11982868;
	setAttr -s 8 ".vt[0:7]"  -0.5 -0.5 0.5 0.5 -0.5 0.5 -0.5 0.5 0.5 0.5 0.5 0.5
		 -0.5 0.5 -0.5 0.5 0.5 -0.5 -0.5 -0.5 -0.5 0.5 -0.5 -0.5;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 4 5 7 6
		f 4 2 9 -4 -9
		mu 0 4 8 9 11 10
		f 4 3 11 -1 -11
		mu 0 4 12 13 15 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube13";
	rename -uid "CECAA74A-46B5-8246-A721-879E9CD81DCF";
	setAttr ".t" -type "double3" 14.808564213476268 0.13482725274524243 9.9635756126405575 ;
	setAttr ".s" -type "double3" 0.52867720668238449 2.5957507028047555 1.9822203524664297 ;
createNode mesh -n "pCubeShape13" -p "pCube13";
	rename -uid "4850D9ED-449F-4904-DE04-21AD7CE835D1";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.50990468263626099 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 4 ".pt[16:19]" -type "float3"  0.80091661 0.077378131 0 
		-0.80091661 0.077378131 0 -0.80091661 0.077378131 0 0.80091661 0.077378131 0;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode mesh -n "polySurfaceShape3" -p "pCube13";
	rename -uid "2431C0A6-4142-9C37-BD2D-13A05FDB66AF";
	setAttr -k off ".v";
	setAttr ".io" yes;
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -3.5809948 0.5 0.050805021 
		5.1120481 0.5 0.050805021 -3.5809948 -0.21564943 0.050805002 5.1120481 -0.21564943 
		0.050805002 -3.5809948 -0.21564943 -0.00022584677 5.1120481 -0.21564943 -0.00022584677 
		-3.5809948 0.5 -0.00022584677 5.1120481 0.5 -0.00022584677;
	setAttr -s 8 ".vt[0:7]"  -0.5 -0.5 0.5 0.5 -0.5 0.5 -0.5 0.5 0.5 0.5 0.5 0.5
		 -0.5 0.5 -0.5 0.5 0.5 -0.5 -0.5 -0.5 -0.5 0.5 -0.5 -0.5;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 4 5 7 6
		f 4 2 9 -4 -9
		mu 0 4 8 9 11 10
		f 4 3 11 -1 -11
		mu 0 4 12 13 15 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube14";
	rename -uid "2DF963B1-41E7-DFE3-39DB-BB9DEBAB9E3B";
	setAttr ".t" -type "double3" 7.941541938719288 0.13482725274524243 9.9635756126405575 ;
	setAttr ".s" -type "double3" 0.52867720668238449 2.5957507028047555 1.9822203524664297 ;
createNode mesh -n "pCubeShape14" -p "pCube14";
	rename -uid "DEFB5B72-4ED3-E9EE-A92C-639390F06B24";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.50990468263626099 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 44 ".uvst[0].uvsp[0:43]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0.22719133
		 0 0.22719133 1 0.22719133 0 0.22719133 1 0.22719133 0 0.22719133 1 0.22719133 0 0.22719133
		 1 0.79261804 0 0.79261804 1 0.79261804 0 0.79261804 1 0.79261804 0 0.79261804 1 0.79261804
		 0 0.79261804 1 0.22719133 0 0.79261804 0 0.79261804 1 0.22719133 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 4 ".pt[16:19]" -type "float3"  0.80091661 0.077378131 0 
		-0.80091661 0.077378131 0 -0.80091661 0.077378131 0 0.80091661 0.077378131 0;
	setAttr -s 20 ".vt[0:19]"  -4.080996037 0 0.55080503 5.61204576 0 0.55080503
		 -3.81182384 0.28435054 0.55080503 5.61204576 0.28435054 0.55080503 -3.81182384 0.28435054 -0.50022584
		 5.61204576 0.28435054 -0.50022584 -4.080996037 0 -0.50022584 5.61204576 0 -0.50022584
		 -1.26123047 0.28435057 0.55080503 -1.26123047 0.28435057 -0.50022584 -1.53040528 0 -0.50022584
		 -1.53040528 0 0.55080503 4.057197094 0.28435054 0.55080503 4.057197094 0.28435054 -0.50022584
		 4.057197094 0 -0.50022584 4.057197094 0 0.55080503 -1.26123047 0.45685059 0.55080503
		 4.057197094 0.45685056 0.55080503 4.057197094 0.45685056 -0.50022584 -1.26123047 0.45685059 -0.50022584;
	setAttr -s 36 ".ed[0:35]"  0 11 0 2 8 0 4 9 0 6 10 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0 8 12 1 9 13 1 8 9 0 10 14 0 9 10 1 11 15 0 10 11 1
		 11 8 1 12 3 0 13 5 0 12 13 0 14 7 0 13 14 1 15 1 0 14 15 1 15 12 1 8 16 0 12 17 0
		 16 17 0 13 18 0 17 18 0 9 19 0 19 18 0 16 19 0;
	setAttr -s 18 -ch 72 ".fc[0:17]" -type "polyFaces" 
		f 4 0 19 -2 -5
		mu 0 4 0 30 25 2
		f 4 1 14 -3 -7
		mu 0 4 4 24 27 6
		f 4 2 16 -4 -9
		mu 0 4 8 26 29 10
		f 4 3 18 -1 -11
		mu 0 4 12 28 31 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22
		f 4 30 32 -35 -36
		mu 0 4 40 41 42 43
		f 4 -17 13 24 -16
		mu 0 4 29 26 34 37
		f 4 -19 15 26 -18
		mu 0 4 31 28 36 39
		f 4 -20 17 27 -13
		mu 0 4 25 30 38 33
		f 4 20 7 -22 -23
		mu 0 4 32 5 7 35
		f 4 -25 21 9 -24
		mu 0 4 37 34 9 11
		f 4 -27 23 11 -26
		mu 0 4 39 36 13 15
		f 4 -28 25 5 -21
		mu 0 4 33 38 1 3
		f 4 12 29 -31 -29
		mu 0 4 24 32 41 40
		f 4 22 31 -33 -30
		mu 0 4 32 35 42 41
		f 4 -14 33 34 -32
		mu 0 4 35 27 43 42
		f 4 -15 28 35 -34
		mu 0 4 27 24 40 43;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode mesh -n "polySurfaceShape3" -p "pCube14";
	rename -uid "61DD2A27-47BD-5F53-241E-20B58DA9F42E";
	setAttr -k off ".v";
	setAttr ".io" yes;
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -3.5809948 0.5 0.050805021 
		5.1120481 0.5 0.050805021 -3.5809948 -0.21564943 0.050805002 5.1120481 -0.21564943 
		0.050805002 -3.5809948 -0.21564943 -0.00022584677 5.1120481 -0.21564943 -0.00022584677 
		-3.5809948 0.5 -0.00022584677 5.1120481 0.5 -0.00022584677;
	setAttr -s 8 ".vt[0:7]"  -0.5 -0.5 0.5 0.5 -0.5 0.5 -0.5 0.5 0.5 0.5 0.5 0.5
		 -0.5 0.5 -0.5 0.5 0.5 -0.5 -0.5 -0.5 -0.5 0.5 -0.5 -0.5;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 4 5 7 6
		f 4 2 9 -4 -9
		mu 0 4 8 9 11 10
		f 4 3 11 -1 -11
		mu 0 4 12 13 15 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube15";
	rename -uid "EC9AD660-41FE-BA35-902D-8997B54B7AEC";
	setAttr ".t" -type "double3" 7.941541938719288 0.13482725274524243 14.120962161003927 ;
	setAttr ".s" -type "double3" 0.52867720668238449 2.5957507028047555 1.9822203524664297 ;
createNode mesh -n "pCubeShape15" -p "pCube15";
	rename -uid "55DD97D7-4071-5028-2894-8CA651BCAB2C";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.50990468263626099 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 44 ".uvst[0].uvsp[0:43]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0.22719133
		 0 0.22719133 1 0.22719133 0 0.22719133 1 0.22719133 0 0.22719133 1 0.22719133 0 0.22719133
		 1 0.79261804 0 0.79261804 1 0.79261804 0 0.79261804 1 0.79261804 0 0.79261804 1 0.79261804
		 0 0.79261804 1 0.22719133 0 0.79261804 0 0.79261804 1 0.22719133 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 4 ".pt[16:19]" -type "float3"  0.80091661 0.077378131 0 
		-0.80091661 0.077378131 0 -0.80091661 0.077378131 0 0.80091661 0.077378131 0;
	setAttr -s 20 ".vt[0:19]"  -4.080996037 0 0.55080503 5.61204576 0 0.55080503
		 -3.81182384 0.28435054 0.55080503 5.61204576 0.28435054 0.55080503 -3.81182384 0.28435054 -0.50022584
		 5.61204576 0.28435054 -0.50022584 -4.080996037 0 -0.50022584 5.61204576 0 -0.50022584
		 -1.26123047 0.28435057 0.55080503 -1.26123047 0.28435057 -0.50022584 -1.53040528 0 -0.50022584
		 -1.53040528 0 0.55080503 4.057197094 0.28435054 0.55080503 4.057197094 0.28435054 -0.50022584
		 4.057197094 0 -0.50022584 4.057197094 0 0.55080503 -1.26123047 0.45685059 0.55080503
		 4.057197094 0.45685056 0.55080503 4.057197094 0.45685056 -0.50022584 -1.26123047 0.45685059 -0.50022584;
	setAttr -s 36 ".ed[0:35]"  0 11 0 2 8 0 4 9 0 6 10 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0 8 12 1 9 13 1 8 9 0 10 14 0 9 10 1 11 15 0 10 11 1
		 11 8 1 12 3 0 13 5 0 12 13 0 14 7 0 13 14 1 15 1 0 14 15 1 15 12 1 8 16 0 12 17 0
		 16 17 0 13 18 0 17 18 0 9 19 0 19 18 0 16 19 0;
	setAttr -s 18 -ch 72 ".fc[0:17]" -type "polyFaces" 
		f 4 0 19 -2 -5
		mu 0 4 0 30 25 2
		f 4 1 14 -3 -7
		mu 0 4 4 24 27 6
		f 4 2 16 -4 -9
		mu 0 4 8 26 29 10
		f 4 3 18 -1 -11
		mu 0 4 12 28 31 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22
		f 4 30 32 -35 -36
		mu 0 4 40 41 42 43
		f 4 -17 13 24 -16
		mu 0 4 29 26 34 37
		f 4 -19 15 26 -18
		mu 0 4 31 28 36 39
		f 4 -20 17 27 -13
		mu 0 4 25 30 38 33
		f 4 20 7 -22 -23
		mu 0 4 32 5 7 35
		f 4 -25 21 9 -24
		mu 0 4 37 34 9 11
		f 4 -27 23 11 -26
		mu 0 4 39 36 13 15
		f 4 -28 25 5 -21
		mu 0 4 33 38 1 3
		f 4 12 29 -31 -29
		mu 0 4 24 32 41 40
		f 4 22 31 -33 -30
		mu 0 4 32 35 42 41
		f 4 -14 33 34 -32
		mu 0 4 35 27 43 42
		f 4 -15 28 35 -34
		mu 0 4 27 24 40 43;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode mesh -n "polySurfaceShape3" -p "pCube15";
	rename -uid "00EF313D-4F55-953F-8808-53AC89AB428D";
	setAttr -k off ".v";
	setAttr ".io" yes;
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -3.5809948 0.5 0.050805021 
		5.1120481 0.5 0.050805021 -3.5809948 -0.21564943 0.050805002 5.1120481 -0.21564943 
		0.050805002 -3.5809948 -0.21564943 -0.00022584677 5.1120481 -0.21564943 -0.00022584677 
		-3.5809948 0.5 -0.00022584677 5.1120481 0.5 -0.00022584677;
	setAttr -s 8 ".vt[0:7]"  -0.5 -0.5 0.5 0.5 -0.5 0.5 -0.5 0.5 0.5 0.5 0.5 0.5
		 -0.5 0.5 -0.5 0.5 0.5 -0.5 -0.5 -0.5 -0.5 0.5 -0.5 -0.5;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 4 5 7 6
		f 4 2 9 -4 -9
		mu 0 4 8 9 11 10
		f 4 3 11 -1 -11
		mu 0 4 12 13 15 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube16";
	rename -uid "32BCAB1F-4BDA-467C-C927-5AABC0C76D86";
	setAttr ".t" -type "double3" 14.808564213476268 0.13482725274524243 14.120962161003927 ;
	setAttr ".s" -type "double3" 0.52867720668238449 2.5957507028047555 1.9822203524664297 ;
createNode mesh -n "pCubeShape16" -p "pCube16";
	rename -uid "D97A0DC7-4BFE-BD11-A860-40B661C7B3FB";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.50990468263626099 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 44 ".uvst[0].uvsp[0:43]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0.22719133
		 0 0.22719133 1 0.22719133 0 0.22719133 1 0.22719133 0 0.22719133 1 0.22719133 0 0.22719133
		 1 0.79261804 0 0.79261804 1 0.79261804 0 0.79261804 1 0.79261804 0 0.79261804 1 0.79261804
		 0 0.79261804 1 0.22719133 0 0.79261804 0 0.79261804 1 0.22719133 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 4 ".pt[16:19]" -type "float3"  0.80091661 0.077378131 0 
		-0.80091661 0.077378131 0 -0.80091661 0.077378131 0 0.80091661 0.077378131 0;
	setAttr -s 20 ".vt[0:19]"  -4.080996037 0 0.55080503 5.61204576 0 0.55080503
		 -3.81182384 0.28435054 0.55080503 5.61204576 0.28435054 0.55080503 -3.81182384 0.28435054 -0.50022584
		 5.61204576 0.28435054 -0.50022584 -4.080996037 0 -0.50022584 5.61204576 0 -0.50022584
		 -1.26123047 0.28435057 0.55080503 -1.26123047 0.28435057 -0.50022584 -1.53040528 0 -0.50022584
		 -1.53040528 0 0.55080503 4.057197094 0.28435054 0.55080503 4.057197094 0.28435054 -0.50022584
		 4.057197094 0 -0.50022584 4.057197094 0 0.55080503 -1.26123047 0.45685059 0.55080503
		 4.057197094 0.45685056 0.55080503 4.057197094 0.45685056 -0.50022584 -1.26123047 0.45685059 -0.50022584;
	setAttr -s 36 ".ed[0:35]"  0 11 0 2 8 0 4 9 0 6 10 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0 8 12 1 9 13 1 8 9 0 10 14 0 9 10 1 11 15 0 10 11 1
		 11 8 1 12 3 0 13 5 0 12 13 0 14 7 0 13 14 1 15 1 0 14 15 1 15 12 1 8 16 0 12 17 0
		 16 17 0 13 18 0 17 18 0 9 19 0 19 18 0 16 19 0;
	setAttr -s 18 -ch 72 ".fc[0:17]" -type "polyFaces" 
		f 4 0 19 -2 -5
		mu 0 4 0 30 25 2
		f 4 1 14 -3 -7
		mu 0 4 4 24 27 6
		f 4 2 16 -4 -9
		mu 0 4 8 26 29 10
		f 4 3 18 -1 -11
		mu 0 4 12 28 31 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22
		f 4 30 32 -35 -36
		mu 0 4 40 41 42 43
		f 4 -17 13 24 -16
		mu 0 4 29 26 34 37
		f 4 -19 15 26 -18
		mu 0 4 31 28 36 39
		f 4 -20 17 27 -13
		mu 0 4 25 30 38 33
		f 4 20 7 -22 -23
		mu 0 4 32 5 7 35
		f 4 -25 21 9 -24
		mu 0 4 37 34 9 11
		f 4 -27 23 11 -26
		mu 0 4 39 36 13 15
		f 4 -28 25 5 -21
		mu 0 4 33 38 1 3
		f 4 12 29 -31 -29
		mu 0 4 24 32 41 40
		f 4 22 31 -33 -30
		mu 0 4 32 35 42 41
		f 4 -14 33 34 -32
		mu 0 4 35 27 43 42
		f 4 -15 28 35 -34
		mu 0 4 27 24 40 43;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode mesh -n "polySurfaceShape3" -p "pCube16";
	rename -uid "532BABD1-4FE7-5A1E-5328-FA937C3B0E6F";
	setAttr -k off ".v";
	setAttr ".io" yes;
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -3.5809948 0.5 0.050805021 
		5.1120481 0.5 0.050805021 -3.5809948 -0.21564943 0.050805002 5.1120481 -0.21564943 
		0.050805002 -3.5809948 -0.21564943 -0.00022584677 5.1120481 -0.21564943 -0.00022584677 
		-3.5809948 0.5 -0.00022584677 5.1120481 0.5 -0.00022584677;
	setAttr -s 8 ".vt[0:7]"  -0.5 -0.5 0.5 0.5 -0.5 0.5 -0.5 0.5 0.5 0.5 0.5 0.5
		 -0.5 0.5 -0.5 0.5 0.5 -0.5 -0.5 -0.5 -0.5 0.5 -0.5 -0.5;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 4 5 7 6
		f 4 2 9 -4 -9
		mu 0 4 8 9 11 10
		f 4 3 11 -1 -11
		mu 0 4 12 13 15 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube17";
	rename -uid "09C2C099-4625-A4BB-2D6E-E09058D2300D";
	setAttr ".t" -type "double3" 13.649024327083495 4.5474735088646413e-15 11.791947212332234 ;
	setAttr ".s" -type "double3" 0.23294950127753181 5.5819039175573675 0.85528060255340899 ;
createNode mesh -n "pCubeShape17" -p "pCube17";
	rename -uid "13AA816E-412A-8206-46E9-F2AC3C213F1E";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -3.5809948 0.5 0.050805021 
		5.1120481 0.5 0.050805021 -3.5809948 -0.090632945 0.050805002 5.1120481 -0.090632945 
		0.050805002 -3.5809948 -0.090632945 -0.00022584677 5.1120481 -0.090632945 -0.00022584677 
		-3.5809948 0.5 -0.00022584677 5.1120481 0.5 -0.00022584677;
	setAttr -s 8 ".vt[0:7]"  -0.5 -0.5 0.5 0.5 -0.5 0.5 -0.5 0.5 0.5 0.5 0.5 0.5
		 -0.5 0.5 -0.5 0.5 0.5 -0.5 -0.5 -0.5 -0.5 0.5 -0.5 -0.5;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 4 5 7 6
		f 4 2 9 -4 -9
		mu 0 4 8 9 11 10
		f 4 3 11 -1 -11
		mu 0 4 12 13 15 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube18";
	rename -uid "3F3660F0-41EB-6708-6AB8-2FB54788BC88";
	setAttr ".t" -type "double3" 9.635649999086807 4.5474735088646413e-15 11.918362799093705 ;
	setAttr ".s" -type "double3" 0.23294950127753181 5.5819039175573675 0.85528060255340899 ;
createNode mesh -n "pCubeShape18" -p "pCube18";
	rename -uid "204A8389-470A-9B40-05E6-9EB3E912CEB1";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -3.5809948 0.5 0.050805021 
		5.1120481 0.5 0.050805021 -3.5809948 -0.090632945 0.050805002 5.1120481 -0.090632945 
		0.050805002 -3.5809948 -0.090632945 -0.00022584677 5.1120481 -0.090632945 -0.00022584677 
		-3.5809948 0.5 -0.00022584677 5.1120481 0.5 -0.00022584677;
	setAttr -s 8 ".vt[0:7]"  -0.5 -0.5 0.5 0.5 -0.5 0.5 -0.5 0.5 0.5 0.5 0.5 0.5
		 -0.5 0.5 -0.5 0.5 0.5 -0.5 -0.5 -0.5 -0.5 0.5 -0.5 -0.5;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 4 5 7 6
		f 4 2 9 -4 -9
		mu 0 4 8 9 11 10
		f 4 3 11 -1 -11
		mu 0 4 12 13 15 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube19";
	rename -uid "755627F6-4BF5-96E3-1AF2-1E9FC0FC1681";
	setAttr ".t" -type "double3" 16.59668908858654 4.5474735088646413e-15 11.876609540779091 ;
	setAttr ".s" -type "double3" 0.047546116598327554 5.5819039175573675 0.43865672455646559 ;
createNode mesh -n "pCubeShape19" -p "pCube19";
	rename -uid "5BC5BB99-4FC5-AF0E-8C65-6CBD094C2632";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -4.9179168 0.5 0.19576931 
		6.4489698 0.5 0.19576931 -4.9179168 0.5461989 0.1957693 6.4489698 0.5461989 0.1957693 
		-4.9179168 0.5461989 -0.14519019 6.4489698 0.5461989 -0.14519019 -4.9179168 0.5 -0.14519019 
		6.4489698 0.5 -0.14519019;
	setAttr -s 8 ".vt[0:7]"  -0.5 -0.5 0.5 0.5 -0.5 0.5 -0.5 0.5 0.5 0.5 0.5 0.5
		 -0.5 0.5 -0.5 0.5 0.5 -0.5 -0.5 -0.5 -0.5 0.5 -0.5 -0.5;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 4 5 7 6
		f 4 2 9 -4 -9
		mu 0 4 8 9 11 10
		f 4 3 11 -1 -11
		mu 0 4 12 13 15 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube20";
	rename -uid "F6015B91-4ECC-182B-410E-E29C2B2389EB";
	setAttr ".t" -type "double3" 7.9420100222034282 4.5474735088646413e-15 11.876609540779091 ;
	setAttr ".s" -type "double3" 0.047546116598327554 5.5819039175573675 0.43865672455646559 ;
createNode mesh -n "pCubeShape20" -p "pCube20";
	rename -uid "789B00B2-47DA-2461-56C0-85BAEFA902B8";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -4.9179168 0.5 0.19576931 
		6.4489698 0.5 0.19576931 -4.9179168 0.5461989 0.1957693 6.4489698 0.5461989 0.1957693 
		-4.9179168 0.5461989 -0.14519019 6.4489698 0.5461989 -0.14519019 -4.9179168 0.5 -0.14519019 
		6.4489698 0.5 -0.14519019;
	setAttr -s 8 ".vt[0:7]"  -0.5 -0.5 0.5 0.5 -0.5 0.5 -0.5 0.5 0.5 0.5 0.5 0.5
		 -0.5 0.5 -0.5 0.5 0.5 -0.5 -0.5 -0.5 -0.5 0.5 -0.5 -0.5;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 4 5 7 6
		f 4 2 9 -4 -9
		mu 0 4 8 9 11 10
		f 4 3 11 -1 -11
		mu 0 4 12 13 15 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube22";
	rename -uid "3AB2776E-42D8-39AD-B4A2-C78DD5D033FB";
	setAttr ".t" -type "double3" 3.3240819495392557 0.13482725274524926 23.602824479232556 ;
	setAttr ".r" -type "double3" 0 90.896518071346634 0 ;
	setAttr ".s" -type "double3" 0.52867720668238449 2.5957507028047555 1.9822203524664297 ;
createNode mesh -n "pCubeShape22" -p "pCube22";
	rename -uid "A782BF45-4F7C-85C6-EAB8-3B859900AAD0";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.50990468263626099 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 44 ".uvst[0].uvsp[0:43]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0.22719133
		 0 0.22719133 1 0.22719133 0 0.22719133 1 0.22719133 0 0.22719133 1 0.22719133 0 0.22719133
		 1 0.79261804 0 0.79261804 1 0.79261804 0 0.79261804 1 0.79261804 0 0.79261804 1 0.79261804
		 0 0.79261804 1 0.22719133 0 0.79261804 0 0.79261804 1 0.22719133 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 4 ".pt[16:19]" -type "float3"  0.80091661 0.077378131 0 
		-0.80091661 0.077378131 0 -0.80091661 0.077378131 0 0.80091661 0.077378131 0;
	setAttr -s 20 ".vt[0:19]"  -4.080996037 0 0.55080503 5.61204576 0 0.55080503
		 -3.81182384 0.28435054 0.55080503 5.61204576 0.28435054 0.55080503 -3.81182384 0.28435054 -0.50022584
		 5.61204576 0.28435054 -0.50022584 -4.080996037 0 -0.50022584 5.61204576 0 -0.50022584
		 -1.26123047 0.28435057 0.55080503 -1.26123047 0.28435057 -0.50022584 -1.53040528 0 -0.50022584
		 -1.53040528 0 0.55080503 4.057197094 0.28435054 0.55080503 4.057197094 0.28435054 -0.50022584
		 4.057197094 0 -0.50022584 4.057197094 0 0.55080503 -1.26123047 0.45685059 0.55080503
		 4.057197094 0.45685056 0.55080503 4.057197094 0.45685056 -0.50022584 -1.26123047 0.45685059 -0.50022584;
	setAttr -s 36 ".ed[0:35]"  0 11 0 2 8 0 4 9 0 6 10 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0 8 12 1 9 13 1 8 9 0 10 14 0 9 10 1 11 15 0 10 11 1
		 11 8 1 12 3 0 13 5 0 12 13 0 14 7 0 13 14 1 15 1 0 14 15 1 15 12 1 8 16 0 12 17 0
		 16 17 0 13 18 0 17 18 0 9 19 0 19 18 0 16 19 0;
	setAttr -s 18 -ch 72 ".fc[0:17]" -type "polyFaces" 
		f 4 0 19 -2 -5
		mu 0 4 0 30 25 2
		f 4 1 14 -3 -7
		mu 0 4 4 24 27 6
		f 4 2 16 -4 -9
		mu 0 4 8 26 29 10
		f 4 3 18 -1 -11
		mu 0 4 12 28 31 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22
		f 4 30 32 -35 -36
		mu 0 4 40 41 42 43
		f 4 -17 13 24 -16
		mu 0 4 29 26 34 37
		f 4 -19 15 26 -18
		mu 0 4 31 28 36 39
		f 4 -20 17 27 -13
		mu 0 4 25 30 38 33
		f 4 20 7 -22 -23
		mu 0 4 32 5 7 35
		f 4 -25 21 9 -24
		mu 0 4 37 34 9 11
		f 4 -27 23 11 -26
		mu 0 4 39 36 13 15
		f 4 -28 25 5 -21
		mu 0 4 33 38 1 3
		f 4 12 29 -31 -29
		mu 0 4 24 32 41 40
		f 4 22 31 -33 -30
		mu 0 4 32 35 42 41
		f 4 -14 33 34 -32
		mu 0 4 35 27 43 42
		f 4 -15 28 35 -34
		mu 0 4 27 24 40 43;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode mesh -n "polySurfaceShape3" -p "pCube22";
	rename -uid "8EAE3C35-41AB-8C20-D3FB-9D84DF6C27EE";
	setAttr -k off ".v";
	setAttr ".io" yes;
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -3.5809948 0.5 0.050805021 
		5.1120481 0.5 0.050805021 -3.5809948 -0.21564943 0.050805002 5.1120481 -0.21564943 
		0.050805002 -3.5809948 -0.21564943 -0.00022584677 5.1120481 -0.21564943 -0.00022584677 
		-3.5809948 0.5 -0.00022584677 5.1120481 0.5 -0.00022584677;
	setAttr -s 8 ".vt[0:7]"  -0.5 -0.5 0.5 0.5 -0.5 0.5 -0.5 0.5 0.5 0.5 0.5 0.5
		 -0.5 0.5 -0.5 0.5 0.5 -0.5 -0.5 -0.5 -0.5 0.5 -0.5 -0.5;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 4 5 7 6
		f 4 2 9 -4 -9
		mu 0 4 8 9 11 10
		f 4 3 11 -1 -11
		mu 0 4 12 13 15 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube23";
	rename -uid "6D9047A9-4546-81F8-4B49-3FA4135EEFF4";
	setAttr ".t" -type "double3" -2.193578808967859 0.13482725274524926 23.602824479232556 ;
	setAttr ".r" -type "double3" 0 90.896518071346634 0 ;
	setAttr ".s" -type "double3" 0.52867720668238449 2.5957507028047555 1.9822203524664297 ;
createNode mesh -n "pCubeShape23" -p "pCube23";
	rename -uid "3C85769E-4DBE-5D48-2D7C-A8917662B101";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.50990468263626099 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 44 ".uvst[0].uvsp[0:43]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0.22719133
		 0 0.22719133 1 0.22719133 0 0.22719133 1 0.22719133 0 0.22719133 1 0.22719133 0 0.22719133
		 1 0.79261804 0 0.79261804 1 0.79261804 0 0.79261804 1 0.79261804 0 0.79261804 1 0.79261804
		 0 0.79261804 1 0.22719133 0 0.79261804 0 0.79261804 1 0.22719133 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 4 ".pt[16:19]" -type "float3"  0.80091661 0.077378131 0 
		-0.80091661 0.077378131 0 -0.80091661 0.077378131 0 0.80091661 0.077378131 0;
	setAttr -s 20 ".vt[0:19]"  -4.080996037 0 0.55080503 5.61204576 0 0.55080503
		 -3.81182384 0.28435054 0.55080503 5.61204576 0.28435054 0.55080503 -3.81182384 0.28435054 -0.50022584
		 5.61204576 0.28435054 -0.50022584 -4.080996037 0 -0.50022584 5.61204576 0 -0.50022584
		 -1.26123047 0.28435057 0.55080503 -1.26123047 0.28435057 -0.50022584 -1.53040528 0 -0.50022584
		 -1.53040528 0 0.55080503 4.057197094 0.28435054 0.55080503 4.057197094 0.28435054 -0.50022584
		 4.057197094 0 -0.50022584 4.057197094 0 0.55080503 -1.26123047 0.45685059 0.55080503
		 4.057197094 0.45685056 0.55080503 4.057197094 0.45685056 -0.50022584 -1.26123047 0.45685059 -0.50022584;
	setAttr -s 36 ".ed[0:35]"  0 11 0 2 8 0 4 9 0 6 10 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0 8 12 1 9 13 1 8 9 0 10 14 0 9 10 1 11 15 0 10 11 1
		 11 8 1 12 3 0 13 5 0 12 13 0 14 7 0 13 14 1 15 1 0 14 15 1 15 12 1 8 16 0 12 17 0
		 16 17 0 13 18 0 17 18 0 9 19 0 19 18 0 16 19 0;
	setAttr -s 18 -ch 72 ".fc[0:17]" -type "polyFaces" 
		f 4 0 19 -2 -5
		mu 0 4 0 30 25 2
		f 4 1 14 -3 -7
		mu 0 4 4 24 27 6
		f 4 2 16 -4 -9
		mu 0 4 8 26 29 10
		f 4 3 18 -1 -11
		mu 0 4 12 28 31 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22
		f 4 30 32 -35 -36
		mu 0 4 40 41 42 43
		f 4 -17 13 24 -16
		mu 0 4 29 26 34 37
		f 4 -19 15 26 -18
		mu 0 4 31 28 36 39
		f 4 -20 17 27 -13
		mu 0 4 25 30 38 33
		f 4 20 7 -22 -23
		mu 0 4 32 5 7 35
		f 4 -25 21 9 -24
		mu 0 4 37 34 9 11
		f 4 -27 23 11 -26
		mu 0 4 39 36 13 15
		f 4 -28 25 5 -21
		mu 0 4 33 38 1 3
		f 4 12 29 -31 -29
		mu 0 4 24 32 41 40
		f 4 22 31 -33 -30
		mu 0 4 32 35 42 41
		f 4 -14 33 34 -32
		mu 0 4 35 27 43 42
		f 4 -15 28 35 -34
		mu 0 4 27 24 40 43;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode mesh -n "polySurfaceShape3" -p "pCube23";
	rename -uid "96976678-4BCE-92F5-7957-F0961C56D04E";
	setAttr -k off ".v";
	setAttr ".io" yes;
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -3.5809948 0.5 0.050805021 
		5.1120481 0.5 0.050805021 -3.5809948 -0.21564943 0.050805002 5.1120481 -0.21564943 
		0.050805002 -3.5809948 -0.21564943 -0.00022584677 5.1120481 -0.21564943 -0.00022584677 
		-3.5809948 0.5 -0.00022584677 5.1120481 0.5 -0.00022584677;
	setAttr -s 8 ".vt[0:7]"  -0.5 -0.5 0.5 0.5 -0.5 0.5 -0.5 0.5 0.5 0.5 0.5 0.5
		 -0.5 0.5 -0.5 0.5 0.5 -0.5 -0.5 -0.5 -0.5 0.5 -0.5 -0.5;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 4 5 7 6
		f 4 2 9 -4 -9
		mu 0 4 8 9 11 10
		f 4 3 11 -1 -11
		mu 0 4 12 13 15 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube24";
	rename -uid "D4382F3A-4987-9479-FA59-DEBFFF466E29";
	setAttr ".t" -type "double3" -15.198119456292769 0 21.721173829050123 ;
	setAttr ".s" -type "double3" 1 8.5305638403579813 5.3789350455246145 ;
createNode mesh -n "pCubeShape24" -p "pCube24";
	rename -uid "E89E70ED-4552-E222-5AF8-6C9CE2B8DD70";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0 0 1 0 0 1 1 1 0
		 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 0 1 0 0 1 1 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -1.2717178 0.5 0.25247943 
		2.9901104 0.5 0.25247943 -1.2717178 -0.1394569 0.25247937 2.9901104 0.021152111 0.25247937 
		-1.2717178 -0.1394569 -0.54505092 2.9901104 0.021152111 -0.54505092 -1.2717178 0.5 
		-0.54505092 2.9901104 0.5 -0.54505092;
	setAttr -s 8 ".vt[0:7]"  -0.5 -0.5 0.5 0.5 -0.5 0.5 -0.5 0.5 0.5 0.5 0.5 0.5
		 -0.5 0.5 -0.5 0.5 0.5 -0.5 -0.5 -0.5 -0.5 0.5 -0.5 -0.5;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 4 5 7 6
		f 4 2 9 -4 -9
		mu 0 4 8 9 11 10
		f 4 3 11 -1 -11
		mu 0 4 12 13 15 14
		f 4 -12 -10 -8 -6
		mu 0 4 16 17 19 18
		f 4 10 4 6 8
		mu 0 4 20 21 23 22;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode lightLinker -s -n "lightLinker1";
	rename -uid "0538EAA3-43BB-7630-6418-F4AB1669B547";
	setAttr -s 2 ".lnk";
	setAttr -s 2 ".slnk";
createNode shapeEditorManager -n "shapeEditorManager";
	rename -uid "3CA7C0B3-4220-2A90-6744-3FA3C966974F";
createNode poseInterpolatorManager -n "poseInterpolatorManager";
	rename -uid "743FF7B5-463C-A3D3-6E1C-0AB521D484F6";
createNode displayLayerManager -n "layerManager";
	rename -uid "4BC74622-40D7-2C98-E989-08ADF32EF19C";
createNode displayLayer -n "defaultLayer";
	rename -uid "DC7D5B84-4959-553C-2FEA-F5AF0959B3A7";
createNode renderLayerManager -n "renderLayerManager";
	rename -uid "4DDBDF8F-4656-DB3B-DE0F-5B9618852CF8";
createNode renderLayer -n "defaultRenderLayer";
	rename -uid "8F61E79E-4079-65C7-F417-5ABA1DA952F5";
	setAttr ".g" yes;
createNode polyPlane -n "polyPlane1";
	rename -uid "97B63DAE-4E55-F850-A6B5-70853D1063F1";
	setAttr ".ax" -type "double3" 0 1 0 ;
	setAttr ".w" 1;
	setAttr ".h" 1;
	setAttr ".sw" 1;
	setAttr ".sh" 1;
	setAttr ".cuv" 2;
createNode polyExtrudeEdge -n "polyExtrudeEdge1";
	rename -uid "E2990831-4F82-EC63-3FDB-07A24DA80568";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[3]";
	setAttr ".ix" -type "matrix" 8 0 0 0 0 1 0 0 0 0 8 0 0 0 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0 0 -4 ;
	setAttr ".rs" 51163;
	setAttr ".lt" -type "double3" 0 16 0 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -4 0 -4 ;
	setAttr ".cbx" -type "double3" 4 0 -4 ;
createNode polyExtrudeEdge -n "polyExtrudeEdge2";
	rename -uid "C2AA6729-4E2A-4ADF-9B25-2488C3B397ED";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[0]";
	setAttr ".ix" -type "matrix" 8 0 0 0 0 1 0 0 0 0 8 0 0 0 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0 0 4 ;
	setAttr ".rs" 36499;
	setAttr ".lt" -type "double3" 0 16 0 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -4 0 4 ;
	setAttr ".cbx" -type "double3" 4 0 4 ;
createNode polyExtrudeEdge -n "polyExtrudeEdge3";
	rename -uid "BB741510-490A-6638-1A98-E9A7316BA8D2";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[1]";
	setAttr ".ix" -type "matrix" 8 0 0 0 0 1 0 0 0 0 8 0 0 0 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" -4 0 0 ;
	setAttr ".rs" 49024;
	setAttr ".lt" -type "double3" 0 16 0 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -4 0 -4 ;
	setAttr ".cbx" -type "double3" -4 0 4 ;
createNode polyExtrudeEdge -n "polyExtrudeEdge4";
	rename -uid "1DEDBC8E-4D27-743A-5CB6-C1BA5F29A96C";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[2]";
	setAttr ".ix" -type "matrix" 8 0 0 0 0 1 0 0 0 0 8 0 0 0 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 4 0 0 ;
	setAttr ".rs" 40379;
	setAttr ".lt" -type "double3" 0 16 0 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" 4 0 -4 ;
	setAttr ".cbx" -type "double3" 4 0 4 ;
createNode deleteComponent -n "deleteComponent1";
	rename -uid "8D8F40B1-488A-1F5B-82B5-AABC1172048E";
	setAttr ".dc" -type "componentList" 1 "f[2]";
createNode polyPlane -n "polyPlane2";
	rename -uid "95BDFEA1-4B86-AF9B-6A06-6AB1DF242FE0";
	setAttr ".ax" -type "double3" 0 1 0 ;
	setAttr ".w" 1;
	setAttr ".h" 1;
	setAttr ".sw" 1;
	setAttr ".sh" 1;
	setAttr ".cuv" 2;
createNode polyCylinder -n "polyCylinder1";
	rename -uid "D2B9A99E-4BA7-AA92-4A9A-5E95D8986F98";
	setAttr ".ax" -type "double3" 0 1 0 ;
	setAttr ".r" 1;
	setAttr ".h" 2;
	setAttr ".sc" 1;
	setAttr ".cuv" 3;
createNode polyExtrudeFace -n "polyExtrudeFace1";
	rename -uid "1C573050-41FB-6EBE-7028-01BC55D19279";
	setAttr ".ics" -type "componentList" 1 "f[0]";
	setAttr ".ix" -type "matrix" 5.0924765500729263 0 0 0 0 5.0924765500729263 0 0 0 0 5.0924765500729263 0
		 1047.2578876111727 61.275989234802644 -1197.4120232440841 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 11.499002 -3.7546863e-07 -12 ;
	setAttr ".rs" 48028;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" 2.9980027074814566 -7.6399375828373192e-07 -20.000000347020727 ;
	setAttr ".cbx" -type "double3" 19.999999821120522 1.3056496541707929e-08 -3.9999994353353769 ;
createNode polyTweak -n "polyTweak1";
	rename -uid "203C75F1-46DE-17EE-592D-EAAA62E0862E";
	setAttr ".uopa" yes;
	setAttr -s 4 ".tk[0:3]" -type "float3"  -96.77684021 -12.032649994
		 106.58628845 137.088165283 -12.032665253 106.58629608 -96.77684021 -12.032649994
		 -107.60268402 137.088165283 -12.032649994 -107.60267639;
createNode polyCube -n "polyCube1";
	rename -uid "6FC8D4B5-4570-1195-35B7-54B06CAF4D7C";
	setAttr ".ax" -type "double3" 0 1 0 ;
	setAttr ".w" 1;
	setAttr ".h" 1;
	setAttr ".d" 1;
	setAttr ".cuv" 2;
createNode polySplitRing -n "polySplitRing1";
	rename -uid "4F3AD243-48FF-AD28-53EE-1DA035A05456";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 2 "e[6:7]" "e[10:11]";
	setAttr ".ix" -type "matrix" 6.2742423488028001 0 0 0 0 8.7428001542445202 0 0 0 0 6.2742423488028001 0
		 725.63981840949134 0 -905.29083953408406 1;
	setAttr ".wt" 0.73479896783828735;
	setAttr ".dr" no;
	setAttr ".re" 7;
	setAttr ".sma" 29.999999999999996;
	setAttr ".div" 1;
	setAttr ".p[0]"  0 0 1;
	setAttr ".fq" yes;
createNode polyTweak -n "polyTweak2";
	rename -uid "5B65DD6C-4F88-D45E-65C8-ECA9B9288F25";
	setAttr ".uopa" yes;
	setAttr -s 8 ".tk[0:7]" -type "float3"  0 50 0 0.5861305 50 0 0 17.961092
		 0 0.5861305 17.961092 0 0 17.961092 -35.12145996 0.5861305 17.961092 -35.12145996
		 0 50 -35.12145996 0.5861305 50 -35.12145996;
createNode polyExtrudeFace -n "polyExtrudeFace2";
	rename -uid "736A8393-4F8C-E986-4195-14988810669F";
	setAttr ".ics" -type "componentList" 1 "f[1]";
	setAttr ".ix" -type "matrix" 6.2742423488028001 0 0 0 0 8.7428001542445202 0 0 0 0 6.2742423488028001 0
		 725.63981840949134 0 -905.29083953408406 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 7.274786 5.9417024 -9.0305443 ;
	setAttr ".rs" 37140;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" 4.1192770096935138 5.941702289030359 -12.145301084247844 ;
	setAttr ".cbx" -type "double3" 10.430294703769746 5.941702289030359 -5.9157872209394409 ;
createNode polySplitRing -n "polySplitRing2";
	rename -uid "77E9A286-4621-1FF3-A8F5-CBADFA365C5B";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 5 "e[6:7]" "e[15]" "e[17]" "e[24]" "e[27]";
	setAttr ".ix" -type "matrix" 6.2742423488028001 0 0 0 0 8.7428001542445202 0 0 0 0 6.2742423488028001 0
		 725.63981840949134 0 -905.29083953408406 1;
	setAttr ".wt" 0.1711936742067337;
	setAttr ".re" 27;
	setAttr ".sma" 29.999999999999996;
	setAttr ".div" 1;
	setAttr ".p[0]"  0 0 1;
	setAttr ".fq" yes;
createNode polyTweak -n "polyTweak3";
	rename -uid "1EDD1C80-4440-74C4-C903-C9B6460AAE51";
	setAttr ".uopa" yes;
	setAttr -s 10 ".tk";
	setAttr ".tk[8]" -type "float3" 0 0 11.365539 ;
	setAttr ".tk[9]" -type "float3" 0 0 11.365539 ;
	setAttr ".tk[10]" -type "float3" 0 0 11.365542 ;
	setAttr ".tk[11]" -type "float3" 0 0 11.365542 ;
	setAttr ".tk[12]" -type "float3" 0 19.594336 0 ;
	setAttr ".tk[13]" -type "float3" 0 19.594336 0 ;
	setAttr ".tk[14]" -type "float3" 0 19.594339 11.365539 ;
	setAttr ".tk[15]" -type "float3" 0 19.594339 11.365539 ;
createNode polySplitRing -n "polySplitRing3";
	rename -uid "20CFF8EB-4F3A-0F5F-DE7A-84B5090C83CC";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 5 "e[15]" "e[17]" "e[28:29]" "e[35]" "e[37]";
	setAttr ".ix" -type "matrix" 6.2742423488028001 0 0 0 0 8.7428001542445202 0 0 0 0 6.2742423488028001 0
		 725.63981840949134 0 -905.29083953408406 1;
	setAttr ".wt" 0.92278879880905151;
	setAttr ".dr" no;
	setAttr ".re" 28;
	setAttr ".sma" 29.999999999999996;
	setAttr ".div" 1;
	setAttr ".p[0]"  0 0 1;
	setAttr ".fq" yes;
createNode polyTweak -n "polyTweak4";
	rename -uid "C72B5A68-4DEC-3306-87F2-3E8167741D84";
	setAttr ".uopa" yes;
	setAttr -s 8 ".tk";
	setAttr ".tk[12]" -type "float3" 0 4.7683716e-07 0 ;
	setAttr ".tk[13]" -type "float3" 0 4.7683716e-07 0 ;
	setAttr ".tk[16]" -type "float3" 0 0 7.7943764 ;
	setAttr ".tk[17]" -type "float3" 0 0 7.7943764 ;
	setAttr ".tk[18]" -type "float3" 0 0 7.7943764 ;
	setAttr ".tk[19]" -type "float3" 0 0 7.7943764 ;
	setAttr ".tk[20]" -type "float3" 0 0 7.7943764 ;
	setAttr ".tk[21]" -type "float3" 0 0 7.7943764 ;
createNode polyExtrudeFace -n "polyExtrudeFace3";
	rename -uid "7DB71D17-4A28-ADDD-7B00-539FEE66CFA4";
	setAttr ".ics" -type "componentList" 1 "f[1]";
	setAttr ".ix" -type "matrix" 6.2742423488028001 0 0 0 0 8.7428001542445202 0 0 0 0 6.2742423488028001 0
		 725.63981840949134 0 -905.29083953408406 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 7.274786 7.6547961 -6.143456 ;
	setAttr ".rs" 59849;
	setAttr ".lt" -type "double3" 1.1368683772161603e-15 0 0.97447453612027635 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" 4.1192770096935138 7.6547960550018423 -6.3711240649084457 ;
	setAttr ".cbx" -type "double3" 10.430294943113099 7.6547960550018423 -5.9157872209394409 ;
createNode polySoftEdge -n "polySoftEdge1";
	rename -uid "B98350DD-4270-3B7E-B071-9EB7307ED48D";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[0:59]";
	setAttr ".ix" -type "matrix" 6.2742423488028001 0 0 0 0 8.7428001542445202 0 0 0 0 6.2742423488028001 0
		 725.63981840949134 0 -905.29083953408406 1;
	setAttr ".a" 0;
createNode polyTweak -n "polyTweak5";
	rename -uid "F0062681-4B97-A34F-578C-7C908CF2E6F2";
	setAttr ".uopa" yes;
	setAttr -s 13 ".tk";
	setAttr ".tk[12]" -type "float3" 0 4.7408357 0 ;
	setAttr ".tk[13]" -type "float3" 0 4.7408357 0 ;
	setAttr ".tk[14]" -type "float3" 0 -1.5718257 0 ;
	setAttr ".tk[15]" -type "float3" 0 -1.5718257 0 ;
	setAttr ".tk[16]" -type "float3" 0 4.7408361 0 ;
	setAttr ".tk[21]" -type "float3" 0 4.7408361 0 ;
	setAttr ".tk[22]" -type "float3" 0 -1.5718255 14.072225 ;
	setAttr ".tk[23]" -type "float3" 0 0 14.072225 ;
	setAttr ".tk[24]" -type "float3" 0 0 14.072225 ;
	setAttr ".tk[25]" -type "float3" 0 0 14.072225 ;
	setAttr ".tk[26]" -type "float3" 0 0 14.072225 ;
	setAttr ".tk[27]" -type "float3" 0 -1.5718255 14.072225 ;
createNode polyCube -n "polyCube2";
	rename -uid "471BA310-457A-B268-728D-1396F5D5C534";
	setAttr ".ax" -type "double3" 0 1 0 ;
	setAttr ".w" 1;
	setAttr ".h" 1;
	setAttr ".d" 1;
	setAttr ".cuv" 2;
createNode polySplitRing -n "polySplitRing4";
	rename -uid "D7014C3B-4D06-80DB-307C-14A3B02F271D";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[0:3]";
	setAttr ".ix" -type "matrix" 0.40447497194513554 0 0 0 0 8.5305638403579813 0 0 0 0 2.8173930255811053 0
		 -1810.9839143254142 -4.5474735088646412e-13 -1559.510575912655 1;
	setAttr ".wt" 0.57844924926757812;
	setAttr ".dr" no;
	setAttr ".re" 2;
	setAttr ".sma" 29.999999999999996;
	setAttr ".div" 1;
	setAttr ".p[0]"  0 0 1;
	setAttr ".fq" yes;
createNode polySoftEdge -n "polySoftEdge2";
	rename -uid "D06B9B1B-4EB2-FA36-DB8F-DE9F55FBEDC5";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[0:19]";
	setAttr ".ix" -type "matrix" 0.40447497194513554 0 0 0 0 8.5305638403579813 0 0 0 0 2.8173930255811053 0
		 -1810.9839143254142 -4.5474735088646412e-13 -1559.510575912655 1;
	setAttr ".a" 0;
createNode polyTweak -n "polyTweak6";
	rename -uid "F7D9178C-4D57-16E5-A9CD-5DBA85C44E56";
	setAttr ".uopa" yes;
	setAttr -s 5 ".tk";
	setAttr ".tk[8]" -type "float3" -71.672073 8.8342075 -8.5265128e-14 ;
	setAttr ".tk[9]" -type "float3" -71.672073 0 -8.5265128e-14 ;
	setAttr ".tk[10]" -type "float3" -71.672073 0 -8.5265128e-14 ;
	setAttr ".tk[11]" -type "float3" -71.672073 8.8342075 -8.5265128e-14 ;
createNode polySplitRing -n "polySplitRing5";
	rename -uid "EF65E241-47F5-9AB1-CC84-4D9B2551F316";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 2 "e[6:7]" "e[10:11]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 8.5305638403579813 0 0 0 0 5.3789350455246145 0
		 -544.95978947367098 0 1156.3490711414934 1;
	setAttr ".wt" 0.87688082456588745;
	setAttr ".dr" no;
	setAttr ".re" 7;
	setAttr ".sma" 29.999999999999996;
	setAttr ".div" 1;
	setAttr ".p[0]"  0 0 1;
	setAttr ".fq" yes;
createNode polyExtrudeFace -n "polyExtrudeFace4";
	rename -uid "3F6C3E43-482C-5957-59B4-7C9FA5C1EE0A";
	setAttr ".ics" -type "componentList" 1 "f[6]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 8.5305638403579813 0 0 0 0 5.3789350455246145 0
		 -544.95978947367098 0 1156.3490711414934 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" -5.245616 3.1440496 5.8761134 ;
	setAttr ".rs" 49869;
	setAttr ".lt" -type "double3" 0 1.1368683772161603e-15 1.3673530535515779 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -10.646689569541397 3.144049580062017 5.5856140063259376 ;
	setAttr ".cbx" -type "double3" 0.1554576472554777 3.144049580062017 6.1666130238263825 ;
createNode polySplitRing -n "polySplitRing6";
	rename -uid "18DACC91-4379-4D0E-EFEB-E0BBF57AAC6E";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[0:3]";
	setAttr ".ix" -type "matrix" 0.52867720668238449 0 0 0 0 2.4253045074200483 0 0 0 0 1.8319114692866612 0
		 1313.4769537494799 13.482725274524244 -104.36434639460447 1;
	setAttr ".wt" 0.22719132900238037;
	setAttr ".re" 1;
	setAttr ".sma" 29.999999999999996;
	setAttr ".div" 1;
	setAttr ".p[0]"  0 0 1;
	setAttr ".fq" yes;
createNode polySplitRing -n "polySplitRing7";
	rename -uid "E37F35C8-4E91-D14F-D909-FC865A995757";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 3 "e[12:13]" "e[15]" "e[17]";
	setAttr ".ix" -type "matrix" 0.52867720668238449 0 0 0 0 2.4253045074200483 0 0 0 0 1.8319114692866612 0
		 1313.4769537494799 13.482725274524244 -104.36434639460447 1;
	setAttr ".wt" 0.73165160417556763;
	setAttr ".dr" no;
	setAttr ".re" 12;
	setAttr ".sma" 29.999999999999996;
	setAttr ".div" 1;
	setAttr ".p[0]"  0 0 1;
	setAttr ".fq" yes;
createNode polyExtrudeFace -n "polyExtrudeFace5";
	rename -uid "3861FF61-4D91-B3DF-131D-0D9C52FA1311";
	setAttr ".ics" -type "componentList" 1 "f[6]";
	setAttr ".ix" -type "matrix" 0.52867720668238449 0 0 0 0 2.4253045074200483 0 0 0 0 1.8319114692866612 0
		 1313.4769537494799 13.482725274524244 -104.36434639460447 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 13.873853 0.82446396 -0.99731517 ;
	setAttr ".rs" 34534;
	setAttr ".lt" -type "double3" 0 -2.8421709430404008e-16 0.41836497094394459 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" 12.467985494284115 0.82446396424798074 -1.9600128992996027 ;
	setAttr ".cbx" -type "double3" 15.279718545560668 0.82446401050699292 -0.034617438593799503 ;
createNode polyTweak -n "polyTweak7";
	rename -uid "03F1E6B6-4D7D-8673-A2FA-9AA16E1BE9AE";
	setAttr ".uopa" yes;
	setAttr -s 10 ".tk";
	setAttr ".tk[2]" -type "float3" 26.917431 0 0 ;
	setAttr ".tk[4]" -type "float3" 26.917431 0 0 ;
	setAttr ".tk[8]" -type "float3" 61.758854 0 0 ;
	setAttr ".tk[9]" -type "float3" 61.758854 0 0 ;
	setAttr ".tk[10]" -type "float3" 34.841427 0 0 ;
	setAttr ".tk[11]" -type "float3" 34.841427 0 0 ;
	setAttr ".tk[12]" -type "float3" 45.53138 0 0 ;
	setAttr ".tk[13]" -type "float3" 45.53138 0 0 ;
	setAttr ".tk[14]" -type "float3" 45.53138 0 0 ;
	setAttr ".tk[15]" -type "float3" 45.53138 0 0 ;
createNode script -n "uiConfigurationScriptNode";
	rename -uid "46B6C20E-4E04-A21F-BC3C-A69C4F15D7A5";
	setAttr ".b" -type "string" (
		"// Maya Mel UI Configuration File.\n//\n//  This script is machine generated.  Edit at your own risk.\n//\n//\n\nglobal string $gMainPane;\nif (`paneLayout -exists $gMainPane`) {\n\n\tglobal int $gUseScenePanelConfig;\n\tint    $useSceneConfig = $gUseScenePanelConfig;\n\tint    $nodeEditorPanelVisible = stringArrayContains(\"nodeEditorPanel1\", `getPanel -vis`);\n\tint    $nodeEditorWorkspaceControlOpen = (`workspaceControl -exists nodeEditorPanel1Window` && `workspaceControl -q -visible nodeEditorPanel1Window`);\n\tint    $menusOkayInPanels = `optionVar -q allowMenusInPanels`;\n\tint    $nVisPanes = `paneLayout -q -nvp $gMainPane`;\n\tint    $nPanes = 0;\n\tstring $editorName;\n\tstring $panelName;\n\tstring $itemFilterName;\n\tstring $panelConfig;\n\n\t//\n\t//  get current state of the UI\n\t//\n\tsceneUIReplacement -update $gMainPane;\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Top View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Top View\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"top\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n"
		+ "            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n"
		+ "            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 976\n            -height 535\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n"
		+ "\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Side View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Side View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"side\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n"
		+ "            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n"
		+ "            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 975\n            -height 535\n"
		+ "            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Front View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Front View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"front\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n"
		+ "            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n"
		+ "            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n"
		+ "            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 976\n            -height 535\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Persp View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Persp View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"persp\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n"
		+ "            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 1\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n"
		+ "            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n"
		+ "            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 1958\n            -height 1114\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"outlinerPanel\" (localizedPanelLabel(\"ToggledOutliner\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\toutlinerPanel -edit -l (localizedPanelLabel(\"ToggledOutliner\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\t$editorName = $panelName;\n        outlinerEditor -e \n            -docTag \"isolOutln_fromSeln\" \n            -showShapes 0\n            -showAssignedMaterials 0\n            -showTimeEditor 1\n            -showReferenceNodes 1\n            -showReferenceMembers 1\n            -showAttributes 0\n            -showConnected 0\n            -showAnimCurvesOnly 0\n            -showMuteInfo 0\n            -organizeByLayer 1\n            -organizeByClip 1\n            -showAnimLayerWeight 1\n            -autoExpandLayers 1\n            -autoExpand 0\n            -showDagOnly 1\n            -showAssets 1\n            -showContainedOnly 1\n            -showPublishedAsConnected 0\n            -showParentContainers 0\n            -showContainerContents 1\n            -ignoreDagHierarchy 0\n            -expandConnections 0\n            -showUpstreamCurves 1\n            -showUnitlessCurves 1\n            -showCompounds 1\n            -showLeafs 1\n            -showNumericAttrsOnly 0\n            -highlightActive 1\n            -autoSelectNewObjects 0\n"
		+ "            -doNotSelectNewObjects 0\n            -dropIsParent 1\n            -transmitFilters 0\n            -setFilter \"defaultSetFilter\" \n            -showSetMembers 1\n            -allowMultiSelection 1\n            -alwaysToggleSelect 0\n            -directSelect 0\n            -isSet 0\n            -isSetMember 0\n            -displayMode \"DAG\" \n            -expandObjects 0\n            -setsIgnoreFilters 1\n            -containersIgnoreFilters 0\n            -editAttrName 0\n            -showAttrValues 0\n            -highlightSecondary 0\n            -showUVAttrsOnly 0\n            -showTextureNodesOnly 0\n            -attrAlphaOrder \"default\" \n            -animLayerFilterOptions \"allAffecting\" \n            -sortOrder \"none\" \n            -longNames 0\n            -niceNames 1\n            -showNamespace 1\n            -showPinIcons 0\n            -mapMotionTrails 0\n            -ignoreHiddenAttribute 0\n            -ignoreOutlinerColor 0\n            -renderFilterVisible 0\n            -renderFilterIndex 0\n            -selectionOrder \"chronological\" \n"
		+ "            -expandAttribute 0\n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"outlinerPanel\" (localizedPanelLabel(\"Outliner\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\toutlinerPanel -edit -l (localizedPanelLabel(\"Outliner\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        outlinerEditor -e \n            -showShapes 0\n            -showAssignedMaterials 0\n            -showTimeEditor 1\n            -showReferenceNodes 0\n            -showReferenceMembers 0\n            -showAttributes 0\n            -showConnected 0\n            -showAnimCurvesOnly 0\n            -showMuteInfo 0\n            -organizeByLayer 1\n            -organizeByClip 1\n            -showAnimLayerWeight 1\n            -autoExpandLayers 1\n            -autoExpand 0\n            -showDagOnly 1\n            -showAssets 1\n            -showContainedOnly 1\n            -showPublishedAsConnected 0\n            -showParentContainers 0\n"
		+ "            -showContainerContents 1\n            -ignoreDagHierarchy 0\n            -expandConnections 0\n            -showUpstreamCurves 1\n            -showUnitlessCurves 1\n            -showCompounds 1\n            -showLeafs 1\n            -showNumericAttrsOnly 0\n            -highlightActive 1\n            -autoSelectNewObjects 0\n            -doNotSelectNewObjects 0\n            -dropIsParent 1\n            -transmitFilters 0\n            -setFilter \"0\" \n            -showSetMembers 1\n            -allowMultiSelection 1\n            -alwaysToggleSelect 0\n            -directSelect 0\n            -displayMode \"DAG\" \n            -expandObjects 0\n            -setsIgnoreFilters 1\n            -containersIgnoreFilters 0\n            -editAttrName 0\n            -showAttrValues 0\n            -highlightSecondary 0\n            -showUVAttrsOnly 0\n            -showTextureNodesOnly 0\n            -attrAlphaOrder \"default\" \n            -animLayerFilterOptions \"allAffecting\" \n            -sortOrder \"none\" \n            -longNames 0\n            -niceNames 1\n"
		+ "            -showNamespace 1\n            -showPinIcons 0\n            -mapMotionTrails 0\n            -ignoreHiddenAttribute 0\n            -ignoreOutlinerColor 0\n            -renderFilterVisible 0\n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"graphEditor\" (localizedPanelLabel(\"Graph Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Graph Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"OutlineEd\");\n            outlinerEditor -e \n                -showShapes 1\n                -showAssignedMaterials 0\n                -showTimeEditor 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n                -showAttributes 1\n                -showConnected 1\n                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -organizeByClip 1\n"
		+ "                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 1\n                -showDagOnly 0\n                -showAssets 1\n                -showContainedOnly 0\n                -showPublishedAsConnected 0\n                -showParentContainers 0\n                -showContainerContents 0\n                -ignoreDagHierarchy 0\n                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 1\n                -showCompounds 0\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n                -autoSelectNewObjects 1\n                -doNotSelectNewObjects 0\n                -dropIsParent 1\n                -transmitFilters 1\n                -setFilter \"0\" \n                -showSetMembers 0\n                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n"
		+ "                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n                -sortOrder \"none\" \n                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 1\n                -mapMotionTrails 1\n                -ignoreHiddenAttribute 0\n                -ignoreOutlinerColor 0\n                -renderFilterVisible 0\n                $editorName;\n\n\t\t\t$editorName = ($panelName+\"GraphEd\");\n            animCurveEditor -e \n                -displayValues 0\n                -snapTime \"integer\" \n                -snapValue \"none\" \n                -showPlayRangeShades \"on\" \n                -lockPlayRangeShades \"off\" \n                -smoothness \"fine\" \n                -resultSamples 1\n                -resultScreenSamples 0\n"
		+ "                -resultUpdate \"delayed\" \n                -showUpstreamCurves 1\n                -keyMinScale 1\n                -stackedCurvesMin -1\n                -stackedCurvesMax 1\n                -stackedCurvesSpace 0.2\n                -preSelectionHighlight 0\n                -constrainDrag 0\n                -valueLinesToggle 1\n                -highlightAffectedCurves 0\n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dopeSheetPanel\" (localizedPanelLabel(\"Dope Sheet\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Dope Sheet\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"OutlineEd\");\n            outlinerEditor -e \n                -showShapes 1\n                -showAssignedMaterials 0\n                -showTimeEditor 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n                -showAttributes 1\n"
		+ "                -showConnected 1\n                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -organizeByClip 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 0\n                -showDagOnly 0\n                -showAssets 1\n                -showContainedOnly 0\n                -showPublishedAsConnected 0\n                -showParentContainers 0\n                -showContainerContents 0\n                -ignoreDagHierarchy 0\n                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 0\n                -showCompounds 1\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n                -autoSelectNewObjects 0\n                -doNotSelectNewObjects 1\n                -dropIsParent 1\n                -transmitFilters 0\n                -setFilter \"0\" \n                -showSetMembers 0\n                -allowMultiSelection 1\n"
		+ "                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n                -sortOrder \"none\" \n                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 0\n                -mapMotionTrails 1\n                -ignoreHiddenAttribute 0\n                -ignoreOutlinerColor 0\n                -renderFilterVisible 0\n                $editorName;\n\n\t\t\t$editorName = ($panelName+\"DopeSheetEd\");\n            dopeSheetEditor -e \n                -displayValues 0\n                -snapTime \"integer\" \n                -snapValue \"none\" \n                -outliner \"dopeSheetPanel1OutlineEd\" \n"
		+ "                -showSummary 1\n                -showScene 0\n                -hierarchyBelow 0\n                -showTicks 1\n                -selectionWindow 0 0 0 0 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"timeEditorPanel\" (localizedPanelLabel(\"Time Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Time Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"clipEditorPanel\" (localizedPanelLabel(\"Trax Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Trax Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = clipEditorNameFromPanel($panelName);\n            clipEditor -e \n                -displayValues 0\n                -snapTime \"none\" \n"
		+ "                -snapValue \"none\" \n                -initialized 0\n                -manageSequencer 0 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"sequenceEditorPanel\" (localizedPanelLabel(\"Camera Sequencer\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Camera Sequencer\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = sequenceEditorNameFromPanel($panelName);\n            clipEditor -e \n                -displayValues 0\n                -snapTime \"none\" \n                -snapValue \"none\" \n                -initialized 0\n                -manageSequencer 1 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"hyperGraphPanel\" (localizedPanelLabel(\"Hypergraph Hierarchy\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n"
		+ "\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Hypergraph Hierarchy\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"HyperGraphEd\");\n            hyperGraph -e \n                -graphLayoutStyle \"hierarchicalLayout\" \n                -orientation \"horiz\" \n                -mergeConnections 0\n                -zoom 1\n                -animateTransition 0\n                -showRelationships 1\n                -showShapes 0\n                -showDeformers 0\n                -showExpressions 0\n                -showConstraints 0\n                -showConnectionFromSelected 0\n                -showConnectionToSelected 0\n                -showConstraintLabels 0\n                -showUnderworld 0\n                -showInvisible 0\n                -transitionFrames 1\n                -opaqueContainers 0\n                -freeform 0\n                -imagePosition 0 0 \n                -imageScale 1\n                -imageEnabled 0\n                -graphType \"DAG\" \n                -heatMapDisplay 0\n                -updateSelection 1\n"
		+ "                -updateNodeAdded 1\n                -useDrawOverrideColor 0\n                -limitGraphTraversal -1\n                -range 0 0 \n                -iconSize \"smallIcons\" \n                -showCachedConnections 0\n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"hyperShadePanel\" (localizedPanelLabel(\"Hypershade\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Hypershade\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"visorPanel\" (localizedPanelLabel(\"Visor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Visor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"nodeEditorPanel\" (localizedPanelLabel(\"Node Editor\")) `;\n"
		+ "\tif ($nodeEditorPanelVisible || $nodeEditorWorkspaceControlOpen) {\n\t\tif (\"\" == $panelName) {\n\t\t\tif ($useSceneConfig) {\n\t\t\t\t$panelName = `scriptedPanel -unParent  -type \"nodeEditorPanel\" -l (localizedPanelLabel(\"Node Editor\")) -mbv $menusOkayInPanels `;\n\n\t\t\t$editorName = ($panelName+\"NodeEditorEd\");\n            nodeEditor -e \n                -allAttributes 0\n                -allNodes 0\n                -autoSizeNodes 1\n                -consistentNameSize 1\n                -createNodeCommand \"nodeEdCreateNodeCommand\" \n                -connectNodeOnCreation 0\n                -connectOnDrop 0\n                -copyConnectionsOnPaste 0\n                -connectionStyle \"bezier\" \n                -defaultPinnedState 0\n                -additiveGraphingMode 0\n                -settingsChangedCallback \"nodeEdSyncControls\" \n                -traversalDepthLimit -1\n                -keyPressCommand \"nodeEdKeyPressCommand\" \n                -nodeTitleMode \"name\" \n                -gridSnap 0\n                -gridVisibility 1\n                -crosshairOnEdgeDragging 0\n"
		+ "                -popupMenuScript \"nodeEdBuildPanelMenus\" \n                -showNamespace 1\n                -showShapes 1\n                -showSGShapes 0\n                -showTransforms 1\n                -useAssets 1\n                -syncedSelection 1\n                -extendToShapes 1\n                -editorMode \"default\" \n                -hasWatchpoint 0\n                $editorName;\n\t\t\t}\n\t\t} else {\n\t\t\t$label = `panel -q -label $panelName`;\n\t\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Node Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"NodeEditorEd\");\n            nodeEditor -e \n                -allAttributes 0\n                -allNodes 0\n                -autoSizeNodes 1\n                -consistentNameSize 1\n                -createNodeCommand \"nodeEdCreateNodeCommand\" \n                -connectNodeOnCreation 0\n                -connectOnDrop 0\n                -copyConnectionsOnPaste 0\n                -connectionStyle \"bezier\" \n                -defaultPinnedState 0\n                -additiveGraphingMode 0\n"
		+ "                -settingsChangedCallback \"nodeEdSyncControls\" \n                -traversalDepthLimit -1\n                -keyPressCommand \"nodeEdKeyPressCommand\" \n                -nodeTitleMode \"name\" \n                -gridSnap 0\n                -gridVisibility 1\n                -crosshairOnEdgeDragging 0\n                -popupMenuScript \"nodeEdBuildPanelMenus\" \n                -showNamespace 1\n                -showShapes 1\n                -showSGShapes 0\n                -showTransforms 1\n                -useAssets 1\n                -syncedSelection 1\n                -extendToShapes 1\n                -editorMode \"default\" \n                -hasWatchpoint 0\n                $editorName;\n\t\t\tif (!$useSceneConfig) {\n\t\t\t\tpanel -e -l $label $panelName;\n\t\t\t}\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"createNodePanel\" (localizedPanelLabel(\"Create Node\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Create Node\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"polyTexturePlacementPanel\" (localizedPanelLabel(\"UV Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"UV Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"renderWindowPanel\" (localizedPanelLabel(\"Render View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Render View\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"shapePanel\" (localizedPanelLabel(\"Shape Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tshapePanel -edit -l (localizedPanelLabel(\"Shape Editor\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"posePanel\" (localizedPanelLabel(\"Pose Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tposePanel -edit -l (localizedPanelLabel(\"Pose Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dynRelEdPanel\" (localizedPanelLabel(\"Dynamic Relationships\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Dynamic Relationships\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"relationshipPanel\" (localizedPanelLabel(\"Relationship Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Relationship Editor\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"referenceEditorPanel\" (localizedPanelLabel(\"Reference Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Reference Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"componentEditorPanel\" (localizedPanelLabel(\"Component Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Component Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dynPaintScriptedPanelType\" (localizedPanelLabel(\"Paint Effects\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Paint Effects\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"scriptEditorPanel\" (localizedPanelLabel(\"Script Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Script Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"profilerPanel\" (localizedPanelLabel(\"Profiler Tool\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Profiler Tool\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"contentBrowserPanel\" (localizedPanelLabel(\"Content Browser\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Content Browser\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\tif ($useSceneConfig) {\n        string $configName = `getPanel -cwl (localizedPanelLabel(\"Current Layout\"))`;\n        if (\"\" != $configName) {\n\t\t\tpanelConfiguration -edit -label (localizedPanelLabel(\"Current Layout\")) \n\t\t\t\t-userCreated false\n\t\t\t\t-defaultImage \"vacantCell.xP:/\"\n\t\t\t\t-image \"\"\n\t\t\t\t-sc false\n\t\t\t\t-configString \"global string $gMainPane; paneLayout -e -cn \\\"single\\\" -ps 1 100 100 $gMainPane;\"\n\t\t\t\t-removeAllPanels\n\t\t\t\t-ap false\n\t\t\t\t\t(localizedPanelLabel(\"Persp View\")) \n\t\t\t\t\t\"modelPanel\"\n"
		+ "\t\t\t\t\t\"$panelName = `modelPanel -unParent -l (localizedPanelLabel(\\\"Persp View\\\")) -mbv $menusOkayInPanels `;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -cam `findStartUpCamera persp` \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 0\\n    -headsUpDisplay 1\\n    -holdOuts 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 0\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 1\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 32768\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -depthOfFieldPreview 1\\n    -maxConstantTransparency 1\\n    -rendererName \\\"vp2Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -controllers 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -particleInstancers 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -greasePencils 1\\n    -shadows 0\\n    -captureSequenceNumber -1\\n    -width 1958\\n    -height 1114\\n    -sceneRenderFilter 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t\t\"modelPanel -edit -l (localizedPanelLabel(\\\"Persp View\\\")) -mbv $menusOkayInPanels  $panelName;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -cam `findStartUpCamera persp` \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 0\\n    -headsUpDisplay 1\\n    -holdOuts 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 0\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 1\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 32768\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -depthOfFieldPreview 1\\n    -maxConstantTransparency 1\\n    -rendererName \\\"vp2Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -controllers 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -particleInstancers 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -greasePencils 1\\n    -shadows 0\\n    -captureSequenceNumber -1\\n    -width 1958\\n    -height 1114\\n    -sceneRenderFilter 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t$configName;\n\n            setNamedPanelLayout (localizedPanelLabel(\"Current Layout\"));\n        }\n\n        panelHistory -e -clear mainPanelHistory;\n        sceneUIReplacement -clear;\n\t}\n\n\ngrid -spacing 1 -size 20 -divisions 1 -displayAxes yes -displayGridLines yes -displayDivisionLines yes -displayPerspectiveLabels no -displayOrthographicLabels no -displayAxesBold yes -perspectiveLabelPosition axis -orthographicLabelPosition edge;\nviewManip -drawCompass 0 -compassAngle 0 -frontParameters \"\" -homeParameters \"\" -selectionLockParameters \"\";\n}\n");
	setAttr ".st" 3;
createNode script -n "sceneConfigurationScriptNode";
	rename -uid "E3E68C77-47EF-1A2C-96A2-45BA3D90F851";
	setAttr ".b" -type "string" "playbackOptions -min 1 -max 120 -ast 1 -aet 200 ";
	setAttr ".st" 6;
createNode nodeGraphEditorInfo -n "hyperShadePrimaryNodeEditorSavedTabsInfo";
	rename -uid "7EF241C0-4908-158B-CDCF-B6A397D1A165";
	setAttr ".tgi[0].tn" -type "string" "Untitled_1";
	setAttr ".tgi[0].vl" -type "double2" -420.23807853933437 -72.619044733426065 ;
	setAttr ".tgi[0].vh" -type "double2" 445.23807754592372 164.28570775758681 ;
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 2 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 5 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderingList1;
select -ne :initialShadingGroup;
	setAttr -s 30 ".dsm";
	setAttr ".ro" yes;
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultRenderGlobals;
	addAttr -ci true -h true -sn "dss" -ln "defaultSurfaceShader" -dt "string";
	setAttr ".ren" -type "string" "arnold";
	setAttr ".dss" -type "string" "lambert1";
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :defaultColorMgtGlobals;
	setAttr ".cfe" yes;
	setAttr ".cfp" -type "string" "<MAYA_RESOURCES>/OCIO-configs/Maya2022-default/config.ocio";
	setAttr ".wsn" -type "string" "ACEScg";
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
select -ne :ikSystem;
	setAttr -s 4 ".sol";
connectAttr "deleteComponent1.og" "pPlaneShape1.i";
connectAttr "polyExtrudeFace1.out" "pPlaneShape2.i";
connectAttr "polyCylinder1.out" "pCylinderShape1.i";
connectAttr "polySoftEdge1.out" "pCubeShape1.i";
connectAttr "polyCube2.out" "pCubeShape2.i";
connectAttr "polySoftEdge2.out" "pCubeShape5.i";
connectAttr "polyExtrudeFace4.out" "pCubeShape6.i";
connectAttr "polyExtrudeFace5.out" "pCubeShape13.i";
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
connectAttr "layerManager.dli[0]" "defaultLayer.id";
connectAttr "renderLayerManager.rlmi[0]" "defaultRenderLayer.rlid";
connectAttr "polyPlane1.out" "polyExtrudeEdge1.ip";
connectAttr "pPlaneShape1.wm" "polyExtrudeEdge1.mp";
connectAttr "polyExtrudeEdge1.out" "polyExtrudeEdge2.ip";
connectAttr "pPlaneShape1.wm" "polyExtrudeEdge2.mp";
connectAttr "polyExtrudeEdge2.out" "polyExtrudeEdge3.ip";
connectAttr "pPlaneShape1.wm" "polyExtrudeEdge3.mp";
connectAttr "polyExtrudeEdge3.out" "polyExtrudeEdge4.ip";
connectAttr "pPlaneShape1.wm" "polyExtrudeEdge4.mp";
connectAttr "polyExtrudeEdge4.out" "deleteComponent1.ig";
connectAttr "polyTweak1.out" "polyExtrudeFace1.ip";
connectAttr "pPlaneShape2.wm" "polyExtrudeFace1.mp";
connectAttr "polyPlane2.out" "polyTweak1.ip";
connectAttr "polyTweak2.out" "polySplitRing1.ip";
connectAttr "pCubeShape1.wm" "polySplitRing1.mp";
connectAttr "polyCube1.out" "polyTweak2.ip";
connectAttr "polySplitRing1.out" "polyExtrudeFace2.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace2.mp";
connectAttr "polyTweak3.out" "polySplitRing2.ip";
connectAttr "pCubeShape1.wm" "polySplitRing2.mp";
connectAttr "polyExtrudeFace2.out" "polyTweak3.ip";
connectAttr "polyTweak4.out" "polySplitRing3.ip";
connectAttr "pCubeShape1.wm" "polySplitRing3.mp";
connectAttr "polySplitRing2.out" "polyTweak4.ip";
connectAttr "polySplitRing3.out" "polyExtrudeFace3.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace3.mp";
connectAttr "polyTweak5.out" "polySoftEdge1.ip";
connectAttr "pCubeShape1.wm" "polySoftEdge1.mp";
connectAttr "polyExtrudeFace3.out" "polyTweak5.ip";
connectAttr "polySurfaceShape1.o" "polySplitRing4.ip";
connectAttr "pCubeShape5.wm" "polySplitRing4.mp";
connectAttr "polyTweak6.out" "polySoftEdge2.ip";
connectAttr "pCubeShape5.wm" "polySoftEdge2.mp";
connectAttr "polySplitRing4.out" "polyTweak6.ip";
connectAttr "polySurfaceShape2.o" "polySplitRing5.ip";
connectAttr "pCubeShape6.wm" "polySplitRing5.mp";
connectAttr "polySplitRing5.out" "polyExtrudeFace4.ip";
connectAttr "pCubeShape6.wm" "polyExtrudeFace4.mp";
connectAttr "|pCube13|polySurfaceShape3.o" "polySplitRing6.ip";
connectAttr "pCubeShape13.wm" "polySplitRing6.mp";
connectAttr "polySplitRing6.out" "polySplitRing7.ip";
connectAttr "pCubeShape13.wm" "polySplitRing7.mp";
connectAttr "polyTweak7.out" "polyExtrudeFace5.ip";
connectAttr "pCubeShape13.wm" "polyExtrudeFace5.mp";
connectAttr "polySplitRing7.out" "polyTweak7.ip";
connectAttr "defaultRenderLayer.msg" ":defaultRenderingList1.r" -na;
connectAttr "pPlaneShape1.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pPlaneShape2.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCylinderShape1.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape1.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCylinderShape2.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape2.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape3.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pPlaneShape3.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pPlaneShape4.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape4.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape5.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape6.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape7.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape8.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape9.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape10.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape11.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape12.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape13.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape14.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape15.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape16.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape17.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape18.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape19.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape20.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape22.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape23.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape24.iog" ":initialShadingGroup.dsm" -na;
// End of hub_greyboc.ma

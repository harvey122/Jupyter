// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Valve.VR
{
    using System;
    using UnityEngine;
    
    
    public partial class SteamVR_Input
    {
        
        public static SteamVR_Action_Boolean __actions_default_in_InteractUI;
        
        public static SteamVR_Action_Boolean __actions_default_in_Teleport;
        
        public static SteamVR_Action_Boolean __actions_default_in_GrabPinch;
        
        public static SteamVR_Action_Boolean __actions_default_in_GrabGrip;
        
        public static SteamVR_Action_Pose __actions_default_in_Pose;
        
        public static SteamVR_Action_Skeleton __actions_default_in_SkeletonLeftHand;
        
        public static SteamVR_Action_Skeleton __actions_default_in_SkeletonRightHand;
        
        public static SteamVR_Action_Single __actions_default_in_Squeeze;
        
        public static SteamVR_Action_Vibration __actions_default_out_Haptic;
        
        public static SteamVR_Action_Vector2 __actions_platformer_in_Move;
        
        public static SteamVR_Action_Boolean __actions_platformer_in_Jump;
        
        public static SteamVR_Action_Vector2 __actions_buggy_in_Steering;
        
        public static SteamVR_Action_Single __actions_buggy_in_Throttle;
        
        public static SteamVR_Action_Boolean __actions_buggy_in_Brake;
        
        public static SteamVR_Action_Boolean __actions_buggy_in_Reset;
        
        public static SteamVR_Action_Boolean __actions_htc_viu_in_viu_press_00;
        
        public static SteamVR_Action_Boolean __actions_htc_viu_in_viu_press_01;
        
        public static SteamVR_Action_Boolean __actions_htc_viu_in_viu_press_02;
        
        public static SteamVR_Action_Boolean __actions_htc_viu_in_viu_press_03;
        
        public static SteamVR_Action_Boolean __actions_htc_viu_in_viu_press_04;
        
        public static SteamVR_Action_Boolean __actions_htc_viu_in_viu_press_05;
        
        public static SteamVR_Action_Boolean __actions_htc_viu_in_viu_press_06;
        
        public static SteamVR_Action_Boolean __actions_htc_viu_in_viu_press_07;
        
        public static SteamVR_Action_Boolean __actions_htc_viu_in_viu_press_31;
        
        public static SteamVR_Action_Boolean __actions_htc_viu_in_viu_press_32;
        
        public static SteamVR_Action_Boolean __actions_htc_viu_in_viu_press_33;
        
        public static SteamVR_Action_Boolean __actions_htc_viu_in_viu_press_34;
        
        public static SteamVR_Action_Boolean __actions_htc_viu_in_viu_touch_00;
        
        public static SteamVR_Action_Boolean __actions_htc_viu_in_viu_touch_01;
        
        public static SteamVR_Action_Boolean __actions_htc_viu_in_viu_touch_02;
        
        public static SteamVR_Action_Boolean __actions_htc_viu_in_viu_touch_03;
        
        public static SteamVR_Action_Boolean __actions_htc_viu_in_viu_touch_04;
        
        public static SteamVR_Action_Boolean __actions_htc_viu_in_viu_touch_05;
        
        public static SteamVR_Action_Boolean __actions_htc_viu_in_viu_touch_06;
        
        public static SteamVR_Action_Boolean __actions_htc_viu_in_viu_touch_07;
        
        public static SteamVR_Action_Boolean __actions_htc_viu_in_viu_touch_31;
        
        public static SteamVR_Action_Boolean __actions_htc_viu_in_viu_touch_32;
        
        public static SteamVR_Action_Boolean __actions_htc_viu_in_viu_touch_33;
        
        public static SteamVR_Action_Boolean __actions_htc_viu_in_viu_touch_34;
        
        public static SteamVR_Action_Single __actions_htc_viu_in_viu_axis_0x;
        
        public static SteamVR_Action_Single __actions_htc_viu_in_viu_axis_0y;
        
        public static SteamVR_Action_Single __actions_htc_viu_in_viu_axis_1x;
        
        public static SteamVR_Action_Single __actions_htc_viu_in_viu_axis_1y;
        
        public static SteamVR_Action_Single __actions_htc_viu_in_viu_axis_2x;
        
        public static SteamVR_Action_Single __actions_htc_viu_in_viu_axis_2y;
        
        public static SteamVR_Action_Single __actions_htc_viu_in_viu_axis_3x;
        
        public static SteamVR_Action_Single __actions_htc_viu_in_viu_axis_3y;
        
        public static SteamVR_Action_Single __actions_htc_viu_in_viu_axis_4x;
        
        public static SteamVR_Action_Single __actions_htc_viu_in_viu_axis_4y;
        
        public static SteamVR_Action_Vector2 __actions_htc_viu_in_viu_axis_0xy;
        
        public static SteamVR_Action_Vector2 __actions_htc_viu_in_viu_axis_1xy;
        
        public static SteamVR_Action_Vector2 __actions_htc_viu_in_viu_axis_2xy;
        
        public static SteamVR_Action_Vector2 __actions_htc_viu_in_viu_axis_3xy;
        
        public static SteamVR_Action_Vector2 __actions_htc_viu_in_viu_axis_4xy;
        
        public static SteamVR_Action_Vibration __actions_htc_viu_out_viu_vib_01;
        
        public static void Dynamic_InitializeActions()
        {
            SteamVR_Input.__actions_default_in_InteractUI.Initialize();
            SteamVR_Input.__actions_default_in_Teleport.Initialize();
            SteamVR_Input.__actions_default_in_GrabPinch.Initialize();
            SteamVR_Input.__actions_default_in_GrabGrip.Initialize();
            SteamVR_Input.__actions_default_in_Pose.Initialize();
            SteamVR_Input.__actions_default_in_SkeletonLeftHand.Initialize();
            SteamVR_Input.__actions_default_in_SkeletonRightHand.Initialize();
            SteamVR_Input.__actions_default_in_Squeeze.Initialize();
            SteamVR_Input.__actions_default_out_Haptic.Initialize();
            SteamVR_Input.__actions_platformer_in_Move.Initialize();
            SteamVR_Input.__actions_platformer_in_Jump.Initialize();
            SteamVR_Input.__actions_buggy_in_Steering.Initialize();
            SteamVR_Input.__actions_buggy_in_Throttle.Initialize();
            SteamVR_Input.__actions_buggy_in_Brake.Initialize();
            SteamVR_Input.__actions_buggy_in_Reset.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_press_00.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_press_01.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_press_02.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_press_03.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_press_04.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_press_05.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_press_06.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_press_07.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_press_31.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_press_32.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_press_33.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_press_34.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_touch_00.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_touch_01.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_touch_02.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_touch_03.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_touch_04.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_touch_05.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_touch_06.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_touch_07.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_touch_31.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_touch_32.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_touch_33.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_touch_34.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_axis_0x.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_axis_0y.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_axis_1x.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_axis_1y.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_axis_2x.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_axis_2y.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_axis_3x.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_axis_3y.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_axis_4x.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_axis_4y.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_axis_0xy.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_axis_1xy.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_axis_2xy.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_axis_3xy.Initialize();
            SteamVR_Input.__actions_htc_viu_in_viu_axis_4xy.Initialize();
            SteamVR_Input.__actions_htc_viu_out_viu_vib_01.Initialize();
        }
        
        public static void Dynamic_InitializeInstanceActions()
        {
            Valve.VR.SteamVR_Input.__actions_default_in_InteractUI = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_default_in_InteractUI")));
            Valve.VR.SteamVR_Input.__actions_default_in_Teleport = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_default_in_Teleport")));
            Valve.VR.SteamVR_Input.__actions_default_in_GrabPinch = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_default_in_GrabPinch")));
            Valve.VR.SteamVR_Input.__actions_default_in_GrabGrip = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_default_in_GrabGrip")));
            Valve.VR.SteamVR_Input.__actions_default_in_Pose = ((SteamVR_Action_Pose)(SteamVR_Input_References.GetAction("__actions_default_in_Pose")));
            Valve.VR.SteamVR_Input.__actions_default_in_SkeletonLeftHand = ((SteamVR_Action_Skeleton)(SteamVR_Input_References.GetAction("__actions_default_in_SkeletonLeftHand")));
            Valve.VR.SteamVR_Input.__actions_default_in_SkeletonRightHand = ((SteamVR_Action_Skeleton)(SteamVR_Input_References.GetAction("__actions_default_in_SkeletonRightHand")));
            Valve.VR.SteamVR_Input.__actions_default_in_Squeeze = ((SteamVR_Action_Single)(SteamVR_Input_References.GetAction("__actions_default_in_Squeeze")));
            Valve.VR.SteamVR_Input.__actions_default_out_Haptic = ((SteamVR_Action_Vibration)(SteamVR_Input_References.GetAction("__actions_default_out_Haptic")));
            Valve.VR.SteamVR_Input.__actions_platformer_in_Move = ((SteamVR_Action_Vector2)(SteamVR_Input_References.GetAction("__actions_platformer_in_Move")));
            Valve.VR.SteamVR_Input.__actions_platformer_in_Jump = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_platformer_in_Jump")));
            Valve.VR.SteamVR_Input.__actions_buggy_in_Steering = ((SteamVR_Action_Vector2)(SteamVR_Input_References.GetAction("__actions_buggy_in_Steering")));
            Valve.VR.SteamVR_Input.__actions_buggy_in_Throttle = ((SteamVR_Action_Single)(SteamVR_Input_References.GetAction("__actions_buggy_in_Throttle")));
            Valve.VR.SteamVR_Input.__actions_buggy_in_Brake = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_buggy_in_Brake")));
            Valve.VR.SteamVR_Input.__actions_buggy_in_Reset = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_buggy_in_Reset")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_00 = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_press_00")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_01 = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_press_01")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_02 = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_press_02")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_03 = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_press_03")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_04 = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_press_04")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_05 = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_press_05")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_06 = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_press_06")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_07 = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_press_07")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_31 = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_press_31")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_32 = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_press_32")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_33 = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_press_33")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_34 = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_press_34")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_00 = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_touch_00")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_01 = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_touch_01")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_02 = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_touch_02")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_03 = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_touch_03")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_04 = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_touch_04")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_05 = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_touch_05")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_06 = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_touch_06")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_07 = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_touch_07")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_31 = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_touch_31")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_32 = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_touch_32")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_33 = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_touch_33")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_34 = ((SteamVR_Action_Boolean)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_touch_34")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_0x = ((SteamVR_Action_Single)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_axis_0x")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_0y = ((SteamVR_Action_Single)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_axis_0y")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_1x = ((SteamVR_Action_Single)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_axis_1x")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_1y = ((SteamVR_Action_Single)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_axis_1y")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_2x = ((SteamVR_Action_Single)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_axis_2x")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_2y = ((SteamVR_Action_Single)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_axis_2y")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_3x = ((SteamVR_Action_Single)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_axis_3x")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_3y = ((SteamVR_Action_Single)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_axis_3y")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_4x = ((SteamVR_Action_Single)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_axis_4x")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_4y = ((SteamVR_Action_Single)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_axis_4y")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_0xy = ((SteamVR_Action_Vector2)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_axis_0xy")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_1xy = ((SteamVR_Action_Vector2)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_axis_1xy")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_2xy = ((SteamVR_Action_Vector2)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_axis_2xy")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_3xy = ((SteamVR_Action_Vector2)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_axis_3xy")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_4xy = ((SteamVR_Action_Vector2)(SteamVR_Input_References.GetAction("__actions_htc_viu_in_viu_axis_4xy")));
            Valve.VR.SteamVR_Input.__actions_htc_viu_out_viu_vib_01 = ((SteamVR_Action_Vibration)(SteamVR_Input_References.GetAction("__actions_htc_viu_out_viu_vib_01")));
            Valve.VR.SteamVR_Input.actions = new Valve.VR.SteamVR_Action[]
            {
                    Valve.VR.SteamVR_Input.__actions_default_in_InteractUI,
                    Valve.VR.SteamVR_Input.__actions_default_in_Teleport,
                    Valve.VR.SteamVR_Input.__actions_default_in_GrabPinch,
                    Valve.VR.SteamVR_Input.__actions_default_in_GrabGrip,
                    Valve.VR.SteamVR_Input.__actions_default_in_Pose,
                    Valve.VR.SteamVR_Input.__actions_default_in_SkeletonLeftHand,
                    Valve.VR.SteamVR_Input.__actions_default_in_SkeletonRightHand,
                    Valve.VR.SteamVR_Input.__actions_default_in_Squeeze,
                    Valve.VR.SteamVR_Input.__actions_default_out_Haptic,
                    Valve.VR.SteamVR_Input.__actions_platformer_in_Move,
                    Valve.VR.SteamVR_Input.__actions_platformer_in_Jump,
                    Valve.VR.SteamVR_Input.__actions_buggy_in_Steering,
                    Valve.VR.SteamVR_Input.__actions_buggy_in_Throttle,
                    Valve.VR.SteamVR_Input.__actions_buggy_in_Brake,
                    Valve.VR.SteamVR_Input.__actions_buggy_in_Reset,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_00,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_01,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_02,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_03,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_04,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_05,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_06,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_07,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_31,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_32,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_33,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_34,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_00,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_01,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_02,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_03,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_04,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_05,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_06,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_07,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_31,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_32,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_33,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_34,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_0x,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_0y,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_1x,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_1y,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_2x,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_2y,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_3x,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_3y,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_4x,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_4y,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_0xy,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_1xy,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_2xy,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_3xy,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_4xy,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_out_viu_vib_01};
            Valve.VR.SteamVR_Input.actionsIn = new Valve.VR.SteamVR_Action_In[]
            {
                    Valve.VR.SteamVR_Input.__actions_default_in_InteractUI,
                    Valve.VR.SteamVR_Input.__actions_default_in_Teleport,
                    Valve.VR.SteamVR_Input.__actions_default_in_GrabPinch,
                    Valve.VR.SteamVR_Input.__actions_default_in_GrabGrip,
                    Valve.VR.SteamVR_Input.__actions_default_in_Pose,
                    Valve.VR.SteamVR_Input.__actions_default_in_SkeletonLeftHand,
                    Valve.VR.SteamVR_Input.__actions_default_in_SkeletonRightHand,
                    Valve.VR.SteamVR_Input.__actions_default_in_Squeeze,
                    Valve.VR.SteamVR_Input.__actions_platformer_in_Move,
                    Valve.VR.SteamVR_Input.__actions_platformer_in_Jump,
                    Valve.VR.SteamVR_Input.__actions_buggy_in_Steering,
                    Valve.VR.SteamVR_Input.__actions_buggy_in_Throttle,
                    Valve.VR.SteamVR_Input.__actions_buggy_in_Brake,
                    Valve.VR.SteamVR_Input.__actions_buggy_in_Reset,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_00,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_01,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_02,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_03,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_04,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_05,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_06,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_07,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_31,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_32,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_33,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_34,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_00,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_01,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_02,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_03,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_04,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_05,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_06,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_07,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_31,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_32,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_33,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_34,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_0x,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_0y,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_1x,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_1y,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_2x,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_2y,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_3x,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_3y,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_4x,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_4y,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_0xy,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_1xy,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_2xy,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_3xy,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_4xy};
            Valve.VR.SteamVR_Input.actionsOut = new Valve.VR.SteamVR_Action_Out[]
            {
                    Valve.VR.SteamVR_Input.__actions_default_out_Haptic,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_out_viu_vib_01};
            Valve.VR.SteamVR_Input.actionsVibration = new Valve.VR.SteamVR_Action_Vibration[]
            {
                    Valve.VR.SteamVR_Input.__actions_default_out_Haptic,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_out_viu_vib_01};
            Valve.VR.SteamVR_Input.actionsPose = new Valve.VR.SteamVR_Action_Pose[]
            {
                    Valve.VR.SteamVR_Input.__actions_default_in_Pose};
            Valve.VR.SteamVR_Input.actionsBoolean = new Valve.VR.SteamVR_Action_Boolean[]
            {
                    Valve.VR.SteamVR_Input.__actions_default_in_InteractUI,
                    Valve.VR.SteamVR_Input.__actions_default_in_Teleport,
                    Valve.VR.SteamVR_Input.__actions_default_in_GrabPinch,
                    Valve.VR.SteamVR_Input.__actions_default_in_GrabGrip,
                    Valve.VR.SteamVR_Input.__actions_platformer_in_Jump,
                    Valve.VR.SteamVR_Input.__actions_buggy_in_Brake,
                    Valve.VR.SteamVR_Input.__actions_buggy_in_Reset,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_00,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_01,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_02,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_03,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_04,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_05,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_06,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_07,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_31,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_32,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_33,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_34,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_00,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_01,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_02,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_03,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_04,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_05,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_06,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_07,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_31,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_32,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_33,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_34};
            Valve.VR.SteamVR_Input.actionsSingle = new Valve.VR.SteamVR_Action_Single[]
            {
                    Valve.VR.SteamVR_Input.__actions_default_in_Squeeze,
                    Valve.VR.SteamVR_Input.__actions_buggy_in_Throttle,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_0x,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_0y,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_1x,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_1y,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_2x,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_2y,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_3x,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_3y,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_4x,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_4y};
            Valve.VR.SteamVR_Input.actionsVector2 = new Valve.VR.SteamVR_Action_Vector2[]
            {
                    Valve.VR.SteamVR_Input.__actions_platformer_in_Move,
                    Valve.VR.SteamVR_Input.__actions_buggy_in_Steering,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_0xy,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_1xy,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_2xy,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_3xy,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_4xy};
            Valve.VR.SteamVR_Input.actionsVector3 = new Valve.VR.SteamVR_Action_Vector3[0];
            Valve.VR.SteamVR_Input.actionsSkeleton = new Valve.VR.SteamVR_Action_Skeleton[]
            {
                    Valve.VR.SteamVR_Input.__actions_default_in_SkeletonLeftHand,
                    Valve.VR.SteamVR_Input.__actions_default_in_SkeletonRightHand};
            Valve.VR.SteamVR_Input.actionsNonPoseNonSkeletonIn = new Valve.VR.SteamVR_Action_In[]
            {
                    Valve.VR.SteamVR_Input.__actions_default_in_InteractUI,
                    Valve.VR.SteamVR_Input.__actions_default_in_Teleport,
                    Valve.VR.SteamVR_Input.__actions_default_in_GrabPinch,
                    Valve.VR.SteamVR_Input.__actions_default_in_GrabGrip,
                    Valve.VR.SteamVR_Input.__actions_default_in_Squeeze,
                    Valve.VR.SteamVR_Input.__actions_platformer_in_Move,
                    Valve.VR.SteamVR_Input.__actions_platformer_in_Jump,
                    Valve.VR.SteamVR_Input.__actions_buggy_in_Steering,
                    Valve.VR.SteamVR_Input.__actions_buggy_in_Throttle,
                    Valve.VR.SteamVR_Input.__actions_buggy_in_Brake,
                    Valve.VR.SteamVR_Input.__actions_buggy_in_Reset,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_00,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_01,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_02,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_03,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_04,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_05,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_06,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_07,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_31,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_32,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_33,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_press_34,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_00,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_01,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_02,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_03,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_04,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_05,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_06,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_07,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_31,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_32,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_33,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_touch_34,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_0x,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_0y,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_1x,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_1y,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_2x,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_2y,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_3x,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_3y,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_4x,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_4y,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_0xy,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_1xy,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_2xy,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_3xy,
                    Valve.VR.SteamVR_Input.__actions_htc_viu_in_viu_axis_4xy};
        }
    }
}

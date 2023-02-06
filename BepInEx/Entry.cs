using BepInEx;
using Comfort.Common;
using EFT;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection;
using Aki.Reflection.Patching;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.Runtime.InteropServices;

namespace NVIDIA
{
    [BepInPlugin("com.servph.NVIDIAFlex", "NVIDIA Flex Patch for EFT", "1.0.0")]


    public class Entry : BaseUnityPlugin
    {
        [DllImport("amd_ags_x64")]
        private static extern IntPtr Test();
        [DllImport("cudart64_92")]
        private static extern IntPtr Test1();
        [DllImport("flexUtils")]
        private static extern IntPtr Test2();
        [DllImport("GFSDK_Aftermath_Lib.x64")]
        private static extern IntPtr Test3();
        [DllImport("NvFlexExtReleaseCUDA_x64")]
        private static extern IntPtr Test4();
        [DllImport("NvFlexReleaseCUDA_x64")]
        private static extern IntPtr Test5();
        [DllImport("NvFlexReleaseD3D_x64")]
        private static extern IntPtr Test6();
        [DllImport("nvToolsExt64_1")]
        private static extern IntPtr Test7();


        public static void Awake()
        {

        }

        public void Update()
        {

        }




    }

    
}

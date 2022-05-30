using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
// using xiaoye97;
using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace IcarusInfiniteEnergy
{
    // [BepInDependency("me.xiaoye97.plugin.Dyson.LDBTool", BepInDependency.DependencyFlags.HardDependency)]
    [BepInPlugin("tpxxn.plugin.Dyson.IcarusInfiniteEnergy", "IcarusInfiniteEnergy", "1.0")]
    public class IcarusInfiniteEnergy : BaseUnityPlugin
    {
        void Start()
        {
            //LDBTool.EditDataAction += Edit;
        }

        void Update()
        {
            if (GameMain.data != null && GameMain.data.mainPlayer != null)
            {
                GameMain.data.mainPlayer.mecha.coreEnergy = GameMain.data.mainPlayer.mecha.coreEnergyCap;
            }
        }

        //void Edit(Proto proto)
        //{
        //    if (proto is RecipeProto && proto.ID == 67)
        //    {
        //        var recipe = proto as RecipeProto;
        //        recipe.Items[1] = 1113;
        //    }
        //}
    }
}

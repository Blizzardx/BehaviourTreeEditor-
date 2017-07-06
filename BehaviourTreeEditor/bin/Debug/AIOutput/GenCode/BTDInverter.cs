/**
 * Autogenerated by script gen tool
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using ExcelImproter.Framework.BehaviourTree;
using GameConfigTools.Util;
using UnityEngine;
namespace BehaviourTree
{
	public partial class BTDInverter
	{
		
private double Inverter;
private const string KeyInverter = "Inverter";

		public override void InitNode(BTNodeData btNodeData)
		{
			if (null == btNodeData || btNodeData.m_ParamList == null || btNodeData.m_ParamList.Count == 0)
			{
				Debug.LogError("error node type");
				return;
			}
			for (int i = 0; i < btNodeData.m_ParamList.Count; ++i)
			{
				var param = btNodeData.m_ParamList[i];
				
if (param.m_strName == KeyInverter)
{
    if (!VaildUtil.TryConvert(param.m_Value, out Inverter))
    {
        Debug.LogError("error on parser node paramter " + param.m_strName);
        return;
    }
}

			}
		}
	}
}
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
	public partial class BTCCheckEvent
	{
		
private bool IsTriggerOnce;
private const string KeyIsTriggerOnce = "IsTriggerOnce";
private string EventName;
private const string KeyEventName = "EventName";

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
				
if (param.m_strName == KeyIsTriggerOnce)
{
    if (!VaildUtil.TryConvert(param.m_Value, out IsTriggerOnce))
    {
        Debug.LogError("error on parser node paramter " + param.m_strName);
        return;
    }
}

if (param.m_strName == KeyEventName)
{
    if (!VaildUtil.TryConvert(param.m_Value, out EventName))
    {
        Debug.LogError("error on parser node paramter " + param.m_strName);
        return;
    }
}

			}
		}
	}
}
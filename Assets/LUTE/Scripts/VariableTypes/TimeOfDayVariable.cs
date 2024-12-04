
/*This script has been, partially or completely, generated by the GenerateVariableWindow*/
using UnityEngine;
using LoGaCulture.LUTE;

namespace LoGaCulture.LUTE
{
    /// <summary>
    /// TimeOfDay variable type.
    /// </summary>
    [VariableInfo("Date Time", "TimeOfDay")]
    [AddComponentMenu("")]
	[System.Serializable]
	public class TimeOfDayVariable : BaseVariable<LoGaCulture.LUTE.TimeOfDay>
	{ }

	/// <summary>
	/// Container for a TimeOfDay variable reference or constant value.
	/// </summary>
	[System.Serializable]
	public struct TimeOfDayData
	{
		[SerializeField]
		[VariableProperty("<Value>", typeof(TimeOfDayVariable))]
		public TimeOfDayVariable timeOfDayRef;

		[SerializeField]
		public LoGaCulture.LUTE.TimeOfDay timeOfDayVal;

		public static implicit operator LoGaCulture.LUTE.TimeOfDay(TimeOfDayData TimeOfDayData)
		{
			return TimeOfDayData.Value;
		}

		public TimeOfDayData(LoGaCulture.LUTE.TimeOfDay v)
		{
			timeOfDayVal = v;
			timeOfDayRef = null;
		}

		public LoGaCulture.LUTE.TimeOfDay Value
		{
			get { return (timeOfDayRef == null) ? timeOfDayVal : timeOfDayRef.Value; }
			set { if (timeOfDayRef == null) { timeOfDayVal = value; } else { timeOfDayRef.Value = value; } }
		}

		public string GetDescription()
		{
			if (timeOfDayRef == null)
			{
				return timeOfDayVal.ToString();
			}
			else
			{
				return timeOfDayRef.Key;
			}
		}
	}
}
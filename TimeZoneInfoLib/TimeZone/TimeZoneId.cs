﻿/*
Copyright 2012-2013 Chris Moschini, Brass Nine Design

This code is licensed under the LGPL or MIT license, whichever you prefer.
*/

using System;

using Brass9;


namespace Brass9.TimeZone
{
	public enum TimeZoneId
	{
		[StringValue("None")]
		None,

		[StringValue("UTC")]
		UTC,

		[StringValue("Pacific Standard Time")]
		PST,

		[StringValue("Mountain Standard Time")]
		MST,

		[StringValue("Central Standard Time")]
		CST,

		[StringValue("Eastern Standard Time")]
		EST,

		[StringValue("Hawaiian Standard Time")]
		HAST,

		[StringValue("Alaskan Standard Time")]
		AKST,

		[StringValue("US Mountain Standard Time")]
		AZMST,

		[StringValue("US Eastern Standard Time")]
		INEST,

		[StringValue("Atlantic Standard Time")]
		AST,

		[StringValue("Newfoundland Standard Time")]
		NST,

		[StringValue("SA Western Standard Time")]
		CLT, // South American

		[StringValue("GMT Standard Time")]
		GMT, // Greenwich Mean Time / Grand Meridian Time / GMT

		[StringValue("Central European Standard Time")]
		CET,

		[StringValue("Arabian Standard Time")]
		GST, // Gulf Standard Time, Arabian Standard Time

		[StringValue("China Standard Time")]
		HKT, // Hong Kong Time / China Standard Time

		[StringValue("West Pacific Standard Time")]
		ChST,

		[StringValue("Samoa Standard Time")]
		WST, // West Samoa Standard Time
	}
}

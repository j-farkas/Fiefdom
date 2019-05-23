﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiefdom.Context;

namespace Fiefdom
{
	public static class FiefdomUpdate
	{
		public static HashSet<string> ConnectedUsers = new HashSet<string>();
		public static void UpdateResources(Fief fief)
		{
			foreach (FiefdomPlot plot in fief.FiefdomPlot)
			{
				switch (plot.Type)
				{
					case "Woodcutter":
						fief.FiefdomResources.Where(r => r.Type == "Wood").FirstOrDefault().Quantity += 10;
						break;
					case "Farm":
						fief.FiefdomResources.Where(r => r.Type == "Food").FirstOrDefault().Quantity += 10;
						break;
					case "Quarry":
						fief.FiefdomResources.Where(r => r.Type == "Stone").FirstOrDefault().Quantity += 10;
						break;
					default:
						break;
				}
			}
		}
	}
}

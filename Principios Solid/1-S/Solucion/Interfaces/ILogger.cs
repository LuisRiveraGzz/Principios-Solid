﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid._1_S.Solucion.Interfaces
{
	interface ILogger
	{
		void Info(string message);
		void Debug(string message);
		void Error(string message, Exception e);
	}
}

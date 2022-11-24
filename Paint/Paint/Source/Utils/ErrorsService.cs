using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Source.Utils {
	class InvalidDLL : Exception {
		private string message;
		public override string Message { 
			get { return message; } 
		}

		public InvalidDLL(string fileName) : base() {
			message = $"Невозможно подключить плагин {fileName}";
		}
	}

	class RuntimeDLLError : Exception {
		private string message;
		public override string Message {
			get { return message; }
		}

		public RuntimeDLLError(string name) : base() {
			message = $"Ошибка выполнения библиотеки\"{name}\"";
		}
	}


	static class ErrorsService {
		public static void ShowError(Exception e) {
			MessageBox.Show(e.Message);
		}
	}
}

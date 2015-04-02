namespace library {
	using System;
	using System.Runtime.InteropServices;
	
	public class main{
		//[DllImport("hello_world")]
		//private static extern int hello_world(int num);

		[DllImport("hello_world")]
		private static extern void _inputNum(int num);

		[DllImport("hello_world")]
		private static extern int _outputNum();

		[DllImport("hello_world")]
		private static extern int _inputString([MarshalAs(UnmanagedType.LPArray)] byte[] buf);

		[DllImport("hello_world")]
		private static extern IntPtr _outputString();

		public void inputNum(int num){
			_inputNum(num);
		}

		public int outputNum(){
			return _outputNum();
		}

		public string inputStr(string str){
			byte[] buf = System.Text.Encoding.UTF8.GetBytes(str);
			int num = _inputString(buf);
			return num.ToString();
		}

		public string outputStr(){
			byte* buf;
			int num = _outputString(buf);
			return System.Text.Encoding.UTF8.GetString (buf) + ":" + num;
		}
	}
}

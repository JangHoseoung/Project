using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Manager
{
    class IniManager
    {
        [DllImport("kernel32.dll")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileSection(string lpAppName, byte[] lpReturnedString, int nSize, string lpFileName);

        private string m_path;

        public string Path
        {
            get {
                return m_path;
            }
            set {
                m_path = value;
            }
        }
        public IniManager() { 
            m_path = 
            System.IO.Directory.GetCurrentDirectory()+"/information.ini";
        }
        public IniManager(string path)
        {
            m_path = path;
        }

        //ini읽기
        public string GetIniValue(string Section, string Key)
        {
            StringBuilder sb = new StringBuilder();
            int Flag = GetPrivateProfileString(Section, Key, "", sb, 500, Path);//);
            return sb.ToString();
        }
        //ini쓰기
        public long SetIniValue(string Section, string Key, string Value) { 
            return WritePrivateProfileString(Section, Key, Value, Path);
        }

        public long WriteString(string aSection, string aKey, string aValue)
        {
            return (WritePrivateProfileString(aSection, aKey, aValue, Path));
        }

        public long WriteInteger(string aSection, string aKey, int aValue)
        {
            return (WritePrivateProfileString(aSection, aKey, aValue.ToString(), Path));
        }
        public string ReadString(string aSection, string aKey, string aDefault)
        {
            StringBuilder sb = new StringBuilder(500);

            int Flag = GetPrivateProfileString(aSection, aKey, aDefault, sb, 500, Path);

            return sb.ToString();
        }
        public String ReadString(string Section, string Key)
        {

            StringBuilder sb = new StringBuilder(500);

            int Flag = GetPrivateProfileString(Section, Key, "", sb, 500, Path);

            return sb.ToString();
        }

        public int ReadInteger(string Section, string Key)
        {
            StringBuilder sb = new StringBuilder(500);

            int Flag = GetPrivateProfileString(Section, Key, "", sb, 500, Path);
            String _strBuffer = sb.ToString();
            if (_strBuffer.Length > 0)
            {
                return Convert.ToInt32(_strBuffer);
            }
            else { return 0; }
        }

        public int ReadInteger(string Section, string Key, int aDefault)
        {
            StringBuilder sb = new StringBuilder(500);

            int Flag = GetPrivateProfileString(Section, Key, aDefault.ToString(), sb, 500, Path);
            String _strBuffer = sb.ToString();
            if (_strBuffer.Length > 0)
            {
                return Convert.ToInt32(_strBuffer);
            }
            else { return 0; }
        }

    }
}

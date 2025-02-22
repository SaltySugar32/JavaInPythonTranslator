﻿namespace JavaInPythonTranslator
{
    /// <summary>
    /// <br>lexClass - класс лексемы</br>
    /// <br>regEx - содержимое лексемы</br>
    /// </summary>
    struct LexicalClasses
    {
        private String lexClass = "";
        private String regEx;

        public LexicalClasses(String lexClass, String regEx)
        {
            this.lexClass = lexClass;
            this.regEx = new String(regEx);
        }

        public String getLexClass()
        {
            return this.lexClass;
        }

        public String getRegEx()
        {
            return this.regEx;
        }
    }

    /// <summary>
    /// <br>type - тип лексемы</br>
    /// <br>value - содержимое лексемы</br>
    /// </summary>
    struct LexList
    {
        public string type;
        public string value;

        public LexList(string type, string value) : this()
        {
            this.type = type;
            this.value = value;
        }
    }

    struct TreeNode
    {
        public LexList lexem;
        public List<TreeNode> nextLevelNodes;

        public TreeNode(string type, string value, List<TreeNode> nextLevelNodes) : this()
        {
            lexem.type = type;
            lexem.value = value;
            this.nextLevelNodes = nextLevelNodes;
        }

        public TreeNode(LexList lexem, List<TreeNode> nextLevelNodes) : this()
        {
            this.lexem = lexem;
            this.nextLevelNodes = nextLevelNodes;
        }
    }

    internal class Globals
    {
        /// <summary>
        /// <br>Если = 0, то логи не должны выводиться в принципе</br>
        /// <br>Если = 1, то должны выводиться только отчёты о работе блоков</br>
        /// <br>Если >= 2, то может выводиться любая информация, которая нужна для отладки</br>
        /// <br>Блок if должен выглядеть так: if (Globals.logVerboseLevel {== или >=} ?) ...</br>
        /// </summary>
        public static int logVerboseLevel = 404;

        ///<summary>Переменная, отвечающая за добавление в список токенов пробелов из входного текста.</summary>
        public static bool lexSpaces = false;

        public static List<LexicalClasses> letterClasses = new();
        public static List<LexicalClasses> operatorClasses = new();
        public static List<LexicalClasses> dividerClasses = new();

        public static string wholeNumber = "NN";
        public static string fractionaNumber = "NP";
        public static string charNumber = "NC";
        public static string stringNumber = "NS";

        public static string identificator = "ID";
    }
}

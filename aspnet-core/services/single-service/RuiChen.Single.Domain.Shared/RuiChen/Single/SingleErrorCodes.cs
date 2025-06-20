namespace RuiChen.Single;

public static class SingleErrorCodes
{
    public const string Namespace = "Single";

    public static class Author
    {
        public const string Prefix = Namespace + ":00";
        /// <summary>
        /// 作者 {Name} 已经存在!
        /// </summary>
        public const string AuthorAlreadyExists = Prefix + "001";
    }

}

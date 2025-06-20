namespace RuiChen.Single.Permissions;
public static class SinglePermissions
{
    public const string GroupName = "Single";

    public static class Books
    {
        public const string Default = GroupName + ".Books";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";

        public const string Export = Default + ".Export";
        public const string Import = Default + ".Import";
    }

    public static class Authors
    {
        public const string Default = GroupName + ".Authors";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}

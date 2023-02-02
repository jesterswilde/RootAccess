public enum Permission
{
    Guest,
    Admin,
    Root
}
public static class PermissionExt
{
    public static Permission Greatest(this Permission a, Permission b)
    {
        if (a == Permission.Root || b == Permission.Root)
            return Permission.Root;
        if (b == Permission.Admin || b == Permission.Admin)
            return Permission.Admin;
        return Permission.Guest;
    }
    public static bool HasPermission(this Permission role, Permission perm)
    {
        if (perm == Permission.Guest)
            return true;
        if (perm == Permission.Admin)
            return role != Permission.Guest;
        return role == Permission.Root;
    }
    public static string AccessColor(this Permission role, Permission perm)
    {
        if (role.HasPermission(perm))
            return TColor.Access;
        else if (perm == Permission.Admin)
            return TColor.Admin;
        else
            return TColor.Root;

    }
}

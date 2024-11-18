namespace ApiCrud.Students;

public static class StudentsRoutes
{
    public static void AddStudentsRoutes(this WebApplication app)
    {
        app.MapGet(pattern: "studants", handler: () => "Hello studants!");
    }
}
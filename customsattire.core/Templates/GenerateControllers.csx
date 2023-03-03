public string WriteCode()
{
    CodeBuilder.Clear();

    CodeBuilder.AppendLine("using AutoMapper;");
    CodeBuilder.AppendLine($"using {Entity.Models.First().ModelNamespace};");
    CodeBuilder.AppendLine($"using {Entity.Context.ContextNamespace};");
    CodeBuilder.AppendLine($"using FluentValidation;");
    

    CodeBuilder.AppendLine($"namespace {TemplateOptions.Namespace}");
    CodeBuilder.AppendLine("{");

    using (CodeBuilder.Indent())
    {
        GenerateClass();
    }

    CodeBuilder.AppendLine("}");

    return CodeBuilder.ToString();
}

private void GenerateClass()
{
    var entityName = Entity.EntityClass;
    CodeBuilder.AppendLine($"public class {entityName}Controller : EntityControllerBase<{Entity.EntityNamespace}.{Entity.EntityClass}, " +
        $"{entityName}ReadModel, {entityName}CreateModel, {entityName}UpdateModel>");
    CodeBuilder.AppendLine("{");

    using (CodeBuilder.Indent())
    {
        //GenerateEdmModel();
        GenerateConstructors();
        //GenerateDbSets();
        //GenerateOnConfiguring();
    }

    CodeBuilder.AppendLine("}");
}

private void GenerateConstructors()
{
    var entityName = Entity.EntityClass;
    CodeBuilder.AppendLine($"public {entityName}Controller({Entity.Context.ContextNamespace}.{Entity.Context.ContextClass} dataContext, IMapper mapper, IValidator<{entityName}CreateModel> createValidator, IValidator<{entityName}UpdateModel> updateValidator) : " +
        $"base(dataContext, mapper, createValidator, updateValidator)");
    CodeBuilder.AppendLine("{");
    CodeBuilder.AppendLine("}");
}

// run script
WriteCode()
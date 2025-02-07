namespace NookpostBackend.ApiSchemas.Categories.GetAllCategories;

sealed class GetAllCategoriesCategory : NookpostBackend.ApiSchemas.Categories.CategoryData
{
    /// <summary>
    /// UUID of the category object
    /// </summary>
    public string? Uuid { get; set; }
}

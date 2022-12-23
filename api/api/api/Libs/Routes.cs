namespace api.Libs;

public static class Routes
{
  public const string API_AUTH_LOGIN = "Login";
  public const string API_AUTH_REGISTER = "Register";
  public const string API_AUTH_ME = "Me";
  public const string API_AUTH_REFRESH_TOKEN = "RefreshToken";

  public const string API_PRODUCT_GET_PRODUCTS = "GetProducts";
  public const string API_PRODUCT_GET_PRODUCTS_BY_CATEGORY = "GetProducts/{categoryId}";
  public const string API_PRODUCT_GET_PRODUCT_BY_ID = "GetProduct/{id}";

  public const string API_CATEGORIES_GET_CATEGORIES = "GetCategories";


  public const string API_ADMIN_PRODUCT_GET_PRODUCTS = "GetProducts";
  public const string API_ADMIN_PRODUCT_CREATE_PRODUCT = "SaveProduct";
  public const string API_ADMIN_GET_PRODUCT_BY_ID = "GetProduct/{id}";
  public const string API_ADMIN_UPDATE_PRODUCT = "UpdateProduct/{id}";
  public const string API_ADMIN_DELETE_PRODUCT = "DeleteProduct/{id}";

  public const string API_ADMIN_CATEGORY_GET_CATEGORIES = "GetProducts";
  public const string API_ADMIN_CATEGORY_CREATE_CATEGORY = "SaveProduct";
  public const string API_ADMIN_GET_CATEGORY_BY_ID = "GetProduct/{id}";
  public const string API_ADMIN_UPDATE_CATEGORY = "UpdateProduct/{id}";
  public const string API_ADMIN_DELETE_CATEGORY = "DeleteProduct/{id}";
}

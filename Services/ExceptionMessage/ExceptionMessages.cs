namespace Services.ExceptionMessage
{
    public static class ExceptionMessages
    {
        public const string ProductNotFound = "Product not found";
        public const string ProductAlreadyExists = "Product already exists";
        public const string ProductCreationFailed = "Product creation failed";
        public const string ProductUpdateFailed = "Product update failed";
        public const string ProductDeletionFailed = "Product deletion failed";
    }


    public  class ExceptionDisplayMessage:Exception
    {
        public ExceptionDisplayMessage(string message):base(message)
        {
            
        }
        
    }
}
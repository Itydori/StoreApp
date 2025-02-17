using AutoMapper;
using Entities;
using Entities.Dtos;
using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Repositories.Contracts;
using Services.Contracts;
using Services.ExceptionMessage;
using Entities.Dtos;
using System.Collections.Generic;
namespace Services
{
    public class ProductManager : IProductService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;


        public ProductManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public void CreateProduct(ProductDtoForInsertion productDto)
        {
            Product product = _mapper.Map<Product>(productDto);
            _manager.Product.CreateOneProduct(product);
            _manager.Save();
        }

        public void DeleteOneProduct(int id)
        {
            Product product = GetOneProduct(id, true);
            if (product is not null)
            {
                _manager.Product.DeleteOneProduct(product);
                _manager.Save();
            }
        }

        public IEnumerable<Product> GetAllProducts(bool trackChanges)
        {
            return _manager.Product.GetAllProducts(trackChanges);
        }

        public Product? GetOneProduct(int id, bool trackChanges)
        {
            var product = _manager.Product.GetOneProduct(id, trackChanges);
            if (product is null)
            {
                throw new ExceptionDisplayMessage(ExceptionMessages.ProductNotFound);
            }
            else
            {
                return product;
            }
        }

        public ProductDtoForUpdate GetOneProductForUpdate(int id, bool trackChanges)
        {
            var product = GetOneProduct(id, trackChanges);
            var ProductDto = _mapper.Map<ProductDtoForUpdate>(product);
            return ProductDto;
        }
        public void UpdateOneProduct(ProductDtoForUpdate ProductDto)
        {
            var entity = _manager.Product.GetOneProduct(ProductDto.ProductID, true);
            _mapper.Map(ProductDto, entity); // Map to existing entity
            _manager.Product.UpdateOneProduct(entity);
            _manager.Save();

        }


    }
}
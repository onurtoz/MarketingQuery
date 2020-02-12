using GraphQL.Types;
using GraphQLapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLapp.Graphql
{
    public class MaterialType : ObjectGraphType<Material>
    {
        public MaterialType()
        {
            Name = "Material";
            Field(p => p.Id);
            Field(p => p.Name);
            Field(p => p.Piece);
            Field<BrandType>("Brand", resolve: _ => _.Source.Brand);
        }
    }

    public class BrandType : ObjectGraphType<Brand>
    {
        public BrandType()
        {
            Name = "Brand";
            Field(p => p.Id);
            Field(p => p.Name);
        }
    }
}

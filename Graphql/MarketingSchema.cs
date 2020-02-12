using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLapp.Graphql
{
    public class MarketingSchema : Schema
    {
        public MarketingSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<MarketingQuery>();
        }
    }
}

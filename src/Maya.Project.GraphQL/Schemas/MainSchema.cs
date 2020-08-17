using Abp.Dependency;
using GraphQL;
using GraphQL.Types;
using Maya.Project.Queries.Container;

namespace Maya.Project.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IDependencyResolver resolver) :
            base(resolver)
        {
            Query = resolver.Resolve<QueryContainer>();
        }
    }
}
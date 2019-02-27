using Softcode.Bdms.Repository;
using Softcode.Bdms.RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Softcode.Bdms.ApplicationService
{
    public class BaseService<T, Tr, Tv>:IBaseService<T,Tr,Tv> where T : class where Tr : BaseRequestModel<T> where Tv : class
    {

        private readonly IBaseRepository<T> repository;
        public BaseService(IBaseRepository<T> repository)
        {
            this.repository = repository;
        }


        public IQueryable<T> SearchQueryable(BaseRequestModel<T> request)
        {
            IQueryable<T> queryable = repository.Get();
            var expression = request.GetExpression();
            queryable = queryable.Where(expression);
            queryable = request.OrderByFunc()(queryable);
            queryable = request.SkipAndTake(queryable);

            return queryable;
        }

        public bool Add(T model)
        {

            return repository.Add(model);
        }

        public Tv Detail(string id)
        {
            T x = repository.GetDetail(id);
            if (x == null)
            //id vul disos can
            {
                throw new Exception();
            }

            var vm = CreateVmInstance(x);

            return vm;
        }

        public List<Tv> Search(Tr request)
        {

            var queryable = SearchQueryable(request);

            var list = queryable.ToList().ConvertAll(CreateVmInstance);    //hit to database  and execute the query

            return list;
        }

        private static Tv CreateVmInstance(T x)
        {
            return (Tv)Activator.CreateInstance(typeof(Tv), x);
        }

    }
}

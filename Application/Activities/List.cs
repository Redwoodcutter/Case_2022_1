using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Activities
{
    public class List
    {
        public class Query : IRequest<List<Provider>> { }

        public class Handler : IRequestHandler<Query, List<Provider>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Provider>> Handle(Query request, CancellationToken cancellationToken)
            {
                //bu alanda tablo turnicate olmuyormuş.

                var dev5_level = "5";
                var dev4_level = "4";
                var dev3_level = "3";
                var dev2_level = "2";
                var dev1_level = "1";

                //DAHA KISA BİR YOLU OLMALI!!!

                var total_zorluk1 = "0";
                var total_zorluk2 = "0";
                var total_zorluk3 = "0";
                var total_zorluk4 = "0";
                var total_zorluk5 = "0";

                //Quicksort algoritması buraya gelecek.
                
                var List = await _context.Providers.ToListAsync();
                return List;
            }
        }
    }
}
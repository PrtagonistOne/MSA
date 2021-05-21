using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Catalog.API.Entities;
using Catalog.API.Repositories.Interfaces;
using System.Net;

namespace Catalog.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        private readonly IGroupOfDetailRepository _groupOfDetailRepository;
        private readonly IDetailRepository _detailRepository;

        public CatalogController(IGroupOfDetailRepository groupOfDetailRepository, IDetailRepository detailRepository)
        {
            _groupOfDetailRepository = groupOfDetailRepository ?? throw new ArgumentNullException(nameof(groupOfDetailRepository));
            _detailRepository = detailRepository ?? throw new ArgumentNullException(nameof(detailRepository));
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<GroupOfDetail>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<GroupOfDetail>>> GetGroupOfDetails()
        {
            var products = await _groupOfDetailRepository.GetGroupOfDetails();
            return Ok(products);
        }


        [HttpPost]
        [ProducesResponseType(typeof(GroupOfDetail), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<GroupOfDetail>> CreateProduct([FromBody] GroupOfDetail groupOfDetail)
        {
            await _groupOfDetailRepository.CreateGroupOfDetail(groupOfDetail);

            return CreatedAtRoute("GetGroupOfDetail", new { id = groupOfDetail.Id }, groupOfDetail);
        }

        [HttpPut]
        [ProducesResponseType(typeof(GroupOfDetail), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateProduct([FromBody] GroupOfDetail product)
        {
            return Ok(await _groupOfDetailRepository.UpdateGroupOfDetail(product));
        }

        [HttpDelete("{id:length(24)}", Name = "DeleteGroupOfDetail")]
        [ProducesResponseType(typeof(GroupOfDetail), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> DeleteProductById(string id)
        {
            return Ok(await _groupOfDetailRepository.DeleteGroupOfDetail(id));
        }

    }
}

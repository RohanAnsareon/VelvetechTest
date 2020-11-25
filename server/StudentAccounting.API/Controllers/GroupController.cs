using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAccounting.Infrastructure.Entities;
using StudentAccounting.Shared.DTOs.Group;
using StudentAccounting.Shared.Interfaces;

namespace StudentAccounting.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IRepository<Group> _repository;
        private readonly IMapper _mapper;

        public GroupController(IRepository<Group> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<GetGroupResponse>> Get() =>
            _mapper.Map<IEnumerable<GetGroupResponse>>(await _repository.GetAll());


        [HttpGet("{id}")]
        public async Task<GetGroupResponse> Get(Guid id) =>
            _mapper.Map<GetGroupResponse>(await _repository.GetById(id));

        [HttpPost]
        public async Task Post([FromBody] CreateGroupRequest request) =>
            await _repository.Insert(new Group
            {
                Name = request.Name
            });

        [HttpPut("{id}")]
        public async Task Put(Guid id, [FromBody] EditGroupRequest request) =>
            await _repository.Update(new Group
            {
                Id = id,
                Name = request.Name
            });

        [HttpDelete("{id}")]
        public async Task Delete(Guid id) =>
            await _repository.Delete(id);
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace UACS_WebAPI_V3.Controllers
{
    [Route("api/students/{studentId}/addresses")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AddressController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAddressesForStudents(int studentId)
        {
            var student = _repository.Student.GetSingleStudent(studentId, trackChanges: false);
            if (student == null)
            {
                _logger.LogInfo($"Student with id: {studentId} not exists.");
                return NotFound();
            }

            var addressesFromDb = _repository.Address.GetAddresses(studentId, trackChanges: false);

            var addressesDto = _mapper.Map<IEnumerable<AddressDto>>(addressesFromDb);

            return Ok(addressesDto);
        }

        [HttpGet("{addressId}", Name = "GetAddressForStudent")]
        public IActionResult GetAddressForStudent(int studentId, int addressId)
        {
            var student = _repository.Student.GetSingleStudent(studentId, trackChanges: false);
            if (student == null)
            {
                _logger.LogInfo($"Student with id: {studentId} not exists.");
                return NotFound();
            }

            var addressDb = _repository.Address.GetAddress(studentId, addressId, trackChanges: false);

            var address = _mapper.Map<AddressDto>(addressDb);

            return Ok(address);
        }

        [HttpPost]
        public IActionResult CreateAddressForStudent(int studentId, [FromBody] AddressForCreation address)
        {
            if (address == null)
            {
                _logger.LogError("Object sent from client is null.");
                return BadRequest("Object sent from client is null.");
            }

            var student = _repository.Student.GetSingleStudent(studentId, trackChanges: false);
            if (student == null)
            {
                _logger.LogInfo($"Student with id: {studentId} not exists");
                return NotFound();
            }

            var addressEntity = _mapper.Map<Address>(address);

            _repository.Address.CreateAddressForStudent(studentId, addressEntity);
            _repository.Save();

            var addressToReturn = _mapper.Map<AddressDto>(addressEntity);

            return CreatedAtRoute("GetAddressForStudent", new { studentId, addressId = addressToReturn.AddressId },
                addressToReturn);
        }

        [HttpDelete("{addressId}")]
        public IActionResult DeleteAddressForStudent(int studentId, int addressId)
        {
            var student = _repository.Student.GetSingleStudent(studentId, trackChanges: false);
            if (student == null)
            {
                _logger.LogInfo($"Student with id: {studentId} not exists");
                return NotFound();
            }

            var addressForStudent = _repository.Address.GetAddress(studentId, addressId, trackChanges: false);
            if (addressForStudent == null)
            {
                _logger.LogInfo($"Address with id: {addressId} not exists.");
                return NotFound();
            }

            _repository.Address.DeleteAddress(addressForStudent);
            _repository.Save();
            return NoContent();
        }

        [HttpPut("{addressId}")]
        public IActionResult UpdateAddressForStudent(int studentId, int addressId, [FromBody] AddressForUpdateDto address)
        {
            if (address == null)
            {
                _logger.LogError("Object sent from client is null.");
                return BadRequest("Object sent from client is null.");
            }

            var student = _repository.Student.GetSingleStudent(studentId, trackChanges: false);
            if (student == null)
            {
                _logger.LogInfo($"Student with id: {studentId} not exists");
                return NotFound();
            }

            var addressEntity = _repository.Address.GetAddress(studentId, addressId, trackChanges: true);
            if (addressEntity == null)
            {
                _logger.LogInfo($"Address with id: {addressId} not exists.");
                return NotFound();
            }

            _mapper.Map(address, addressEntity);
            _repository.Save();
            return NoContent();

        }

        [HttpPatch("{addressId}")]
        public IActionResult PartiallyUpdatedAddressForStudent(int studentId, int addressId,
            [FromBody] JsonPatchDocument<AddressForUpdateDto> patchDoc)
        {
            if (patchDoc == null)
            {
                _logger.LogError("patchDoc sent from client is null");
                return BadRequest("patchDoc sent from client is null");
            }

            var student = _repository.Student.GetSingleStudent(studentId, trackChanges: false);
            if (student == null)
            {
                _logger.LogInfo($"Student with id: {studentId} not exists");
                return NotFound();
            }

            var addressEntity = _repository.Address.GetAddress(studentId, addressId, trackChanges: true);
            if (addressEntity == null)
            {
                _logger.LogInfo($"Address with id: {addressId} not exists.");
                return NotFound();
            }

            var addressToPach = _mapper.Map<AddressForUpdateDto>(addressEntity);
            patchDoc.ApplyTo(addressToPach);
            _mapper.Map(addressToPach, addressEntity);

            _repository.Save();

            return NoContent();
        }
    }
}

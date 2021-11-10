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

namespace UACS_WebAPI_V3.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public StudentsController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = _repository.Student.GetAllStudents(trackChanges: false);

            var studentsDto = _mapper.Map<IEnumerable<StudentDto>>(students);

            return Ok(studentsDto);
        }

        [HttpGet("{studentId}", Name = "StudentById")]
        public IActionResult GetStudentById(int studentId)
        {
            var student = _repository.Student.GetSingleStudent(studentId, trackChanges: false);
            if (student == null)
            {
                _logger.LogInfo($"Student with id: {studentId} not exists.");
                return NotFound();
            }

            else
            {
                var studentDto = _mapper.Map<StudentDto>(student);
                return Ok(studentDto);
            }
        }

        [HttpPost]
        public IActionResult CreateStudent([FromBody] StudentForCreationDto student)
        {
            if (student == null)
            {
                _logger.LogError("Object sent feom client is null");
                return BadRequest("Object sent from client is null.");
            }

            var studentEntity = _mapper.Map<Student>(student);

            _repository.Student.CreateStudent(studentEntity);
            _repository.Save();

            var studentToReturn = _mapper.Map<StudentDto>(studentEntity);

            return CreatedAtRoute("StudentById", new { studentId = studentToReturn.studentId }, studentToReturn);
        }

        [HttpDelete("{studentId}")]
        public IActionResult DeleteStudent(int studentId)
        {
            var student = _repository.Student.GetSingleStudent(studentId, trackChanges: false);
            if (student == null)
            {
                _logger.LogInfo($"Student with id: {studentId} not exists.");
                return NotFound();
            }

            _repository.Student.DeleteStudent(student);
            _repository.Save();

            return NoContent();
        }

        [HttpPut("{studentId}")]
        public IActionResult UpdateStudent(int studentId, [FromBody] StudentForUpdateDto student)
        {
            if (student == null)
            {
                _logger.LogError("Object sent from client is null.");
                return BadRequest("Object sent from client is null.");
            }

            var studentEntity = _repository.Student.GetSingleStudent(studentId, trackChanges: true);
            if (studentEntity == null)
            {
                _logger.LogInfo($"Student with id: {studentId} not exists");
                return NotFound();
            }

            _mapper.Map(student, studentEntity);
            _repository.Save();

            return NoContent();
        }

    }
}

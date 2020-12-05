import { Injectable } from '@angular/core';
import { Student } from '../models/student';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  students: Student[];

  constructor() {
    this.students = [
      {
        name: 'Orkhan',
        surname: 'Ansar',
        middlename: 'Aydin',
        gender: 'Male',
        studentIdentity: 'Dimbir',
        id: ''
      }
    ]
  }

  getStudents(): Student[] {
    return this.students;
  }

  addStudent(student: Student) {
    this.students.push(student);
  }

  editStudent(student: Student) {
    console.log(student);
    this.students.push(student);
  }
}

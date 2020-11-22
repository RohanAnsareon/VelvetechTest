import {Injectable} from '@angular/core';
import {Student} from '../models/student';
import {Gender} from '../enums/gender.enum';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor() {
  }

  getStudents(): Student[] {
    return [
      new Student(
        '143254-45242-45425',
        'Orkhan',
        'Ansar',
        'Aydin',
        Gender.Male,
        'dimbir'
      ),
      new Student(
        '143254-45242-45426',
        'Sevgi',
        'Yusifova',
        'Ilqar',
        Gender.Female,
        'Love'
      ),
      new Student(
        '143254-45242-45427',
        'Altun',
        'Mursalov',
        'Nazim',
        Gender.Male,
        'Baltun'
      )
    ];
  }
}

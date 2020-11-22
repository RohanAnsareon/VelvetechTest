import {Gender} from '../enums/gender.enum';

export class Student {
  constructor(
    public id: string,
    public name: string,
    public surname: string,
    public middlename: string,
    public gender: Gender,
    public uniqueStudentId: string
  ) { }
}

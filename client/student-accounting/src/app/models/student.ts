import { Gender } from '../enums/gender.enum';

export interface Student {
    id: string;
    name: string;
    surname: string;
    middlename: string;
    gender: string;
    studentIdentity: string;
}

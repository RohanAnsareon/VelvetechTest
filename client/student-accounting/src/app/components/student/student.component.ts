import { Component, OnInit, OnDestroy } from '@angular/core';
import { StudentService } from '../../services/student.service';
import { MatDialog, MatDialogRef } from '@angular/material/dialog';
import { CreateStudentComponent } from '../forms/student/create-student/create-student.component';
import { FormGroup } from '@angular/forms';
import { EditStudentComponent } from '../forms/student/edit-student/edit-student.component';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.scss']
})
export class StudentComponent implements OnInit, OnDestroy {

  private addStudentDialogRef: MatDialogRef<CreateStudentComponent, FormGroup>;
  private editStudentDialogRef: MatDialogRef<EditStudentComponent, FormGroup>;

  constructor(private studentService: StudentService, private dialog: MatDialog) { }

  ngOnInit(): void {

  }

  ngOnDestroy(): void {
  }

  addStudent() {
    this.addStudentDialogRef = this.dialog.open(CreateStudentComponent, {
      width: '350px'
    });

    this.addStudentDialogRef.afterClosed().subscribe(result => {
      if (result) {
        const val = result.value;
        this.studentService.addStudent({
          id: '',
          name: val.name,
          surname: val.surname,
          middlename: val.middlename,
          gender: val.gender,
          studentIdentity: val.studentIdentity
        });
      }
    })
  }

  editStudent() {
    this.editStudentDialogRef = this.dialog.open(EditStudentComponent, {
      width: '350px',
      data: {
        name: 'Orkhan',
        surname: 'Ansar',
        middlename: 'Aydin',
        studentIdentity: 'Dimbir',
        gender: 'Male',
        id: '1234-567-890-354546'
      }
    });

    this.editStudentDialogRef.afterClosed().subscribe(result => {
      if (result) {
        const val = result.value;
        this.studentService.editStudent({
          id: val.id,
          name: val.name,
          surname: val.surname,
          middlename: val.middlename,
          gender: val.gender,
          studentIdentity: val.studentIdentity
        });
      }
    })
  }

}

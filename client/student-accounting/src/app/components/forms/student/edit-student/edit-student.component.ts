import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Student } from 'src/app/models/student';

@Component({
  selector: 'app-edit-student',
  templateUrl: './edit-student.component.html',
  styleUrls: ['./edit-student.component.scss']
})
export class EditStudentComponent implements OnInit {

  userProps: FormGroup;
  id: FormControl;
  name: FormControl;
  surname: FormControl;
  middlename: FormControl;
  gender: FormControl;
  studentIdentity: FormControl;

  constructor(private fb: FormBuilder,
    private dialogRef: MatDialogRef<EditStudentComponent>,
    @Inject(MAT_DIALOG_DATA) private data: Student) {

    // Initialize
    this.id = new FormControl(data.id);
    this.name = new FormControl(data.name, [Validators.maxLength(40), Validators.required]);
    this.surname = new FormControl(data.surname, [Validators.maxLength(40), Validators.required]);
    this.middlename = new FormControl(data.middlename, Validators.maxLength(60));
    this.gender = new FormControl(data.gender);
    this.studentIdentity = new FormControl(data.studentIdentity, [Validators.minLength(6), Validators.maxLength(16)]);

    // Form Group
    this.userProps = fb.group({
      id: this.id,
      name: this.name,
      surname: this.surname,
      middlename: this.middlename,
      gender: this.gender,
      studentIdentity: this.studentIdentity
    });
  }

  ngOnInit(): void {
  }

  onCloseClick() {
    this.dialogRef.close();
  }
}

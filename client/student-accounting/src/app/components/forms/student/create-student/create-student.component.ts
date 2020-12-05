import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-create-student',
  templateUrl: './create-student.component.html',
  styleUrls: ['./create-student.component.scss']
})
export class CreateStudentComponent implements OnInit {

  userProps: FormGroup;
  name = new FormControl('', [Validators.maxLength(40), Validators.required]);
  surname = new FormControl('', [Validators.maxLength(40), Validators.required]);
  middlename = new FormControl('', Validators.maxLength(60));
  gender = new FormControl('Male');
  studentIdentity = new FormControl('', [Validators.minLength(6), Validators.maxLength(16)]);


  constructor(private fb: FormBuilder, private dialogRef: MatDialogRef<CreateStudentComponent>) {

    // Form Group
    this.userProps = fb.group({
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

import { Component, OnInit } from '@angular/core';
import {FormControl} from "@angular/forms";

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {

  // Personal Information Form Controls
  fNameFormControl = new FormControl();
  lNameFormControl = new FormControl();
  dateOfBirthFormControl = new FormControl();
  emailFormControl = new FormControl();

  // User Form Controls
  usernameFormControl = new FormControl();
  passwordFormControl = new FormControl();
  savingsFormControl = new FormControl(0.00);
  chequingFormControl = new FormControl(0.00);
  constructor() { }

  ngOnInit(): void {
  }

}

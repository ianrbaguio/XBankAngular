import { Component, OnInit } from '@angular/core';
import { ErrorStateMatcher } from '@angular/material/core';
import {
  FormControl,
  FormGroupDirective,
  NgForm,
  Validators,
} from '@angular/forms';

/* Error when invalid control is dirty, touched or submitted */
export class SecurityQuestionStateMatcher implements ErrorStateMatcher {
  isErrorState(
    control: FormControl | null,
    form: FormGroupDirective | NgForm | null
  ): boolean {
    const isSubmitted = form && form.submitted;
    return !!(
      control &&
      control.invalid &&
      (control.dirty || control.touched || isSubmitted)
    );
  }
}

@Component({
  selector: 'app-security-question',
  templateUrl: './security-question.component.html',
  styleUrls: ['./security-question.component.scss'],
})
export class SecurityQuestionComponent implements OnInit {
  squestionFormControl = new FormControl('', [Validators.required]);
  constructor() {}

  matcher = new SecurityQuestionStateMatcher();
  ngOnInit(): void {}
}

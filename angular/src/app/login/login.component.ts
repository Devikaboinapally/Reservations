 import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
 loginForm!: FormGroup;

  constructor(private formBuilder: FormBuilder, private _route: Router) { }

  ngOnInit(): void {} 
  onFormSubmission(referenceForForm: NgForm) {
  if (
        referenceForForm.value.userName == 'Devika' &&
        referenceForForm.value.password == 123456
      ) {
        this._route.navigate(['Res']);
      }
    }
    onFormSubmit() {}
  }


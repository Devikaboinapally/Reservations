import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';

import { DataService } from 'src/app/data.service';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.css']
})
export class AddComponent implements OnInit {
  add:any;
  

  constructor(private ds: DataService, @Inject(MAT_DIALOG_DATA) public data:any) { }

  ngOnInit(): void {
  console.log(this.data);
  this.add = new FormGroup({
    Sl_No: new FormControl(''),
    Hotel: new FormControl(''),
    Arrival: new FormControl(''),
    Departure: new FormControl(''),
    Type: new FormControl(''),
    Guests: new FormControl(''),
    Price: new FormControl(''),
  });
  let Adate = this.data.Arrival.split('T');
      let Ddate = this.data.Departure.split('T');
      this.add.patchValue({
        Sl_No: this.data.Sl_No,
        Hotel: this.data.Hotel,
        Arrival: Adate[0],
        Departure: Ddate[0],
        Type: this.data.Type,
        Guests:this.data.Guests,
        Price: this.data.Price,
      });


    }
  save()
  {
    console.log(this.add.value);
    let serializedForm = JSON.stringify(this.add.value);
    console.log(serializedForm);
    this.ds.addData(serializedForm);
   window.location.reload();
  }
}
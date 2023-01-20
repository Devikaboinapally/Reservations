import { Component, OnInit, Inject, AfterViewInit, ViewChild} from '@angular/core';
import { MatDialog,MAT_DIALOG_DATA, MatDialogRef} from '@angular/material/dialog';
import { AddComponent } from '../login/add/add.component';
import { formatDate } from '@angular/common';
import { DecimalPipe } from '@angular/common';
import { DataService } from '../data.service';
import { FormControl, FormGroup,FormBuilder } from '@angular/forms';
import { DeleteComponent } from '../login/delete/delete.component';
import { LoginComponent } from '../login/login.component';
import {MatTable, MatTableDataSource } from '@angular/material/table';
import { Observable } from 'rxjs/internal/Observable';
import { MatSort, Sort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Router } from '@angular/router';
// export interface PeriodicElement {
  


  // Sl_No: number;
  // Hotel: string;
  // Arrival: Date;
  // Departure: Date;
  // Type:string;
  // Guests:number;
  // Price:number;
  // Manage:string;
//}


@Component({
  selector: 'app-res',
  templateUrl: './res.component.html',
  styleUrls: ['./res.component.css']
})
export class ResComponent implements OnInit {
loginForm!: FormGroup;
  displayedColumns:string[] = ['Sl_No', 'Hotel', 'Arrival', 'Departure', 'Type', 'Guests', 'Price', 'Manage'];
 datasource!:MatTableDataSource<any>;
 @ViewChild(MatPaginator) paginator!: MatPaginator;
 @ViewChild(MatSort) matSort!: MatSort



constructor(private ds: DataService, private dialog:MatDialog, private route:Router, formBuilder: FormBuilder, private _liveAnnouncer:LiveAnnouncer) { 
}
list:any = [];
  ngOnInit()  {
this.ds.getData().subscribe((X:any) => {
  this.datasource = new MatTableDataSource(X);
  this.datasource.paginator = this.paginator;
  this.datasource.sort = this.matSort;
  console.log(this.datasource);
})
  }

  backtoHome(){
    this.route.navigate([''])
  }
 

  openDialog()
  {
    this.dialog.open(AddComponent,{
    height: '90%',
    width: '50%',
      
    }).afterClosed();
  }



 clEdit(value:number) {
  console.log(value);
  this.dialog.open(AddComponent,{
    height:'90%',
    width:'90%',
    data:value,
  });
 }


 clDelete(data: number) {
  let dev = this.dialog.open(DeleteComponent, {width: '40%', height: '50%', data: data});
  console.log(data);
  this.ds.deleteData(data);
  window.location.reload();
 }

// @ViewChild(MatPaginator) paginator!: MatPaginator;
// @ViewChild(MatSort) sort!: MatSort;

// ngAfterViewInit(){
//   this.data.sort = this.sort,
//   this.data.paginator = this.paginator
// }
 announceSortChange(sortState: Sort){
  if(sortState.direction){
    this._liveAnnouncer.announce('Sorted $ {sortState.direction}ending');
  }
  else {
    this._liveAnnouncer.announce('Sorting cleared');
  }
 }
 filterData($event : any){
  this.datasource.filter = $event.target.value;
 }
}
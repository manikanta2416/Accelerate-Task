import { Component, OnInit } from '@angular/core';
import { RegisterService } from '../register.service';
import { IRegisterUser } from '../Interface/RegisterInterface';

@Component({
  selector: 'app-view-request',
  templateUrl: './view-request.component.html',
  styleUrls: ['./view-request.component.scss']
})
export class ViewRequestComponent implements OnInit {
   request:IRegisterUser[]=[];
  constructor(private service: RegisterService) {

  }
  ngOnInit() {
    this.ViewRequests();
    }
  ViewRequests() {
    this.service.ViewRequest().subscribe(reponse => {
      this.request = reponse
    },
      errorResponse => {
        this.request = errorResponse
      }

    )
  }
}

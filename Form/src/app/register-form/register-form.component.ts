import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { RegisterService } from '../register.service';
@Component({
  selector: 'app-register-form',
  templateUrl: './register-form.component.html',
  styleUrls: ['./register-form.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class RegisterFormComponent implements OnInit {
  emailPattern = /^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$/;
  RegisterFrom: FormGroup;
  result: boolean=false;

  constructor(private formBuilder: FormBuilder, private registerService: RegisterService) {
    this.RegisterFrom = this.formBuilder.group({
      /*requestorId: ['', [Validators.required]],*/
      requestorEmail: ['', [Validators.required, Validators.pattern(this.emailPattern)]],
      requestorName: ['', [Validators.required, Validators.minLength(4)]],
      Criticality: ['', Validators.required],
      requestingTeam: ['', Validators.required],
      requestingTeamLocation: ['', Validators.required],
      dataUsage: ['', Validators.required],
      criticalityReason: ['', Validators.required],
      howIndexWillBeUsed: ['', Validators.required],
      requiredApplications: ['', Validators.required],
      historyRequired: ['', Validators.required],
      indexType: ['', Validators.required],
      blendComponents: ['', Validators.required],
      indexProvider: ['', Validators.required],
      requiredUniverse: ['', Validators.required],
      returnType: ['', Validators.required],
      constituentsRequired: ['', Validators.required],
      baseCurrency: ['', Validators.required],
      indexName: ['', Validators.required],
      vendorId: ['', Validators.required],
      isWACIDataRequired: ['', Validators.required],
      indexCostApproval: ['', Validators.required],
      allergapproverEmailies: ['', Validators.required],
      requiredHistoryDate: ['', [Validators.required, this.checkDate]],

    });

  }

  ngOnInit(): void {

  }
  checkDate(date: FormControl): any {
    var currentdate = new Date();
    var givendate = new Date(date.value);
    if (givendate == null || givendate <= currentdate) {
      return null;
    } else {
      return {
        dateError: {
          msg: "date should be less than current date"
        }
      }
    }

  }
  submitRegisterForm(form: FormGroup) {
    // const formData=this.RegisterFrom.value;
    // console.log(formData);
    this.registerService.Regsiter(form.value).subscribe(response => {
      this.result = response
      if (this.result == true) {
        alert("successful registration");
      }
    }, errorResponse => {
      this.result = errorResponse
      if (this.result == false) {
        alert("successful registration");
      }
    }

    )
    

  }


}

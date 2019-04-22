import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-experience',
  templateUrl: './experience.component.html',
  styleUrls: ['./experience.component.less']
})
export class ExperienceComponent implements OnInit {

  @Input() companyLogo: string;
  @Input() job: string;
  @Input() time: string;
  @Input() description: string;

  constructor() { }

  ngOnInit() {
  }

}

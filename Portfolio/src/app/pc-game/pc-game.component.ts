import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-pc-game',
  templateUrl: './pc-game.component.html',
  styleUrls: ['./pc-game.component.less']
})
export class PCGameComponent {
  @Input() name:string;
  @Input() description:string;
  @Input() image:string;
  @Input() link:string;
}

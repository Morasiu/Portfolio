import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GameVideoComponent } from './game-video.component';

describe('GameVideoComponent', () => {
  let component: GameVideoComponent;
  let fixture: ComponentFixture<GameVideoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GameVideoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GameVideoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

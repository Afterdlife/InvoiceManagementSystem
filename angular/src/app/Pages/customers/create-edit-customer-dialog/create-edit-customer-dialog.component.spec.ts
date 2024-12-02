import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateEditCustomerDialogComponent } from './create-edit-customer-dialog.component';

describe('CreateEditCustomerDialogComponent', () => {
  let component: CreateEditCustomerDialogComponent;
  let fixture: ComponentFixture<CreateEditCustomerDialogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CreateEditCustomerDialogComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CreateEditCustomerDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

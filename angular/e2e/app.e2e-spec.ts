import { InvoiceManagementSystemTemplatePage } from './app.po';

describe('InvoiceManagementSystem App', function() {
  let page: InvoiceManagementSystemTemplatePage;

  beforeEach(() => {
    page = new InvoiceManagementSystemTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

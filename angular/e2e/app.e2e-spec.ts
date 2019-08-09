import { TCCAssociationTemplatePage } from './app.po';

describe('TCCAssociation App', function() {
  let page: TCCAssociationTemplatePage;

  beforeEach(() => {
    page = new TCCAssociationTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

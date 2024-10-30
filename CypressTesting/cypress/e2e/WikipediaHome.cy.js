describe('Wikipedia Homepage Test', () => {
    it('should load the Wikipedia homepage and check main elements', () => {
        // Visit the Wikipedia homepage
        cy.visit('https://www.wikipedia.org/');
        // Check that the title includes "Wikipedia"
        cy.title().should('include', 'Wikipedia');
        // Check that the Wikipedia logo is visible
        cy.get('.central-featured-logo').should('be.visible');
        // Check that the search input is visible
        cy.get('input#searchInput').should('be.visible');
        // Check that the main language content section is present
        cy.get('.central-featured').should('exist').and('be.visible');
    });
});

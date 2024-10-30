describe('Delfi Homepage Test', () => {
    it('should load the Delfi homepage and check the title and main elements', () => {
        cy.visit('https://www.delfi.ee/');

        // Check that the title contains "Delfi"
        cy.title().should('include', 'Delfi');

        // Wait for the content to load or adjust timeout if necessary
        cy.get('body', { timeout: 10000 }).should('be.visible'); // Ensures the page is loaded

        // Update selector to target a prominent element that is more reliable
        cy.get('.headline-title', { timeout: 10000 }).should('be.visible'); // Update the selector as needed
    });
});
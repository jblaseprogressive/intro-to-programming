import { describe, expect, it } from 'vitest';

 

 

describe('Types in TypeScript', () => {

 

    describe('Implicit Typing', () => {
        it('An Example', () => {
            let a = 10, b = 20, answer;

 

            answer = a + b;

 

            expect(answer).toBe(30);
        })
    })

 

  
})
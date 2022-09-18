import React from 'react'
import { Container } from 'react-bootstrap'
import NbNavbar from './NbNavbar'
function About() {
    return (
        <div>
            <NbNavbar />
            <Container>
                <h1>About Us</h1>
                <p>We developed the Note-Bag with React!</p>
            </Container>
        </div>
    )
}

export default About
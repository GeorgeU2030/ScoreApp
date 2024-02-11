import {Navbar, NavbarBrand, NavbarContent, NavbarItem, Link} from "@nextui-org/react";

export default function NavBar(){

    return (
        <Navbar className="border-2 border-[#23C7D9] rounded-lg">
      <NavbarBrand>
        <img src='/logo.png' className="w-10 h-10 mr-2"></img>
        <p className="font-bold text-inherit">ScoreApp</p>
      </NavbarBrand>
      
      <NavbarContent justify="end">
        <NavbarItem className="lg:flex">
          <Link className="text-white cursor-default">The Mandalorian</Link>
        </NavbarItem>
      </NavbarContent>
    </Navbar>
    )
}
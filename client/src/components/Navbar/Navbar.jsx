import { useRef } from "react";
import { FaBars, FaTimes } from "react-icons/fa";
// import "./navbar.css";
import React, { useState } from 'react'
function Navbar() {
	const navRef = useRef();

	const showNavbar = () => {
		navRef.current.classList.toggle("responsive_nav");
	};
	let Links = [
		{ name: "HOME", link: "/" },
		{ name: "SERVICE", link: "/" },
		{ name: "ABOUT", link: "/" },
		{ name: "BLOG'S", link: "/" },
		{ name: "CONTACT", link: "/" },
	];
	let [open, setOpen] = useState(false);
	return (
		<div className='shadow-md w-full fixed top-0 left-0 z-[990]'>
			<div className='md:flex items-center justify-between bg-white py-4 md:px-10 px-7'>
				<div className='font-bold text-2xl cursor-pointer flex items-center font-[Poppins] 
		text-gray-800'>
					<span className='text-3xl text-indigo-600 mr-1 pt-2'>
						<ion-icon name="logo-ionic"></ion-icon>
					</span>
					Designer
				</div>

				<div onClick={() => setOpen(!open)} className='text-3xl absolute right-8 top-6 cursor-pointer md:hidden'>
					<FaBars name={open ? 'close' : 'menu'}></FaBars>
				</div>

				<ul className={`md:flex md:items-center md:pb-0 pb-12 absolute md:static bg-white md:z-auto z-[-1] left-0 w-full md:w-auto md:pl-0 pl-9 transition-all duration-500 ease-in ${open ? 'top-20 ' : 'top-[-490px]'}`}>
					{
						Links.map((link) => (
							<li key={link.name} className='md:ml-8 text-xl md:my-0 my-7'>
								<a href={link.link} className='text-gray-800 hover:text-gray-400 duration-500'>{link.name}</a>
							</li>
						))
					}
				
				</ul>
			</div>
		</div>
		// <header>
		// 	<h3>LOGO</h3>
		// 	<nav ref={navRef}>
		// 		<a href="/#">Home</a>
		// 		<a href="/#">My work</a>
		// 		<a href="/#">Blog</a>
		// 		<a href="/#">About me</a>
		// 		<button
		// 			className="nav-btn nav-close-btn"
		// 			onClick={showNavbar}>
		// 			<FaTimes />
		// 		</button>
		// 	</nav>
		// 	<button className="nav-btn" onClick={showNavbar}>
		// 		<FaBars />
		// 	</button>
		// </header>
	);
}

export default Navbar;

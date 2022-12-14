import React, { useState } from 'react';
import Button from '../Button'
import {BsLaptop} from 'react-icons/bs';
import {BiHeadphone} from 'react-icons/bi';
import {GiMouse , GiKeyboard} from 'react-icons/gi';
import {SlScreenDesktop} from 'react-icons/sl';
import {TfiApple} from 'react-icons/tfi';
import SubCategory from './SubCategory';
// import {GiMouse} from 'react-icons/gi';

const CategoryProduct = ({}) => {

    // const hoverStyle = {
    // position: absolute;
    // content: "";
    // border-top: 17px solid #ffbf00;
    // right: -0.75rem;
    // width: 0;
    // height: 0;
    // border-top: 17px solid transparent;
    // border-bottom: 17px solid transparent;
    // border-left: 17px solid green;
    // }
    const [isHover, setIsHover] = useState(false);

    const handleMouseOver = () => {
        setIsHover(true);
    };

    const handleMouseOut = () => {
        setIsHover(false);
    };
    return (
        <>
            <div className="bg-[#fff] w-[185px] h-[540px] rounded-sm ">
                <ul className='relative '>
                    <li className='hovermenu hover:bg-[#ea1c04] hover:before:absolute hover:before:right-[-15px] hover:before:border-l-[#ea1c04]  hover:before:z-50  hover:before:border-y-[17px]  hover:before:border-y-[transparent]  hover:before:border-l-[15px] '>
                        <a  className='text-[#505050] text-[13px] flex items-center py-[4px] pr-[4px] pl-[10px] h-[34px] font-medium gap-4 hover:text-[#fff] ' href="client/src/components/catergory/CategoryProduct">
                            <span><BsLaptop className='text-[20px]' /></span>
                            <span>Laptop</span>
                        </a>
                       <div className="">
                        <SubCategory className="" />
                       </div>
                    </li>
                    <li className='hover:bg-[#ea1c04]  '>
                        <a onMouseOver={handleMouseOver} onMouseOut={handleMouseOut} className='text-[#505050] text-[13px] flex items-center py-[4px] pr-[4px] pl-[10px] h-[34px] font-medium gap-4 hover:text-[#fff] ' href="client/src/components/catergory/CategoryProduct">
                            <span><BsLaptop className='text-[20px]' /></span>
                            <span>Laptop Gaming</span>
                        </a>
                    </li>
                    <li className='hover:bg-[#ea1c04]  '>
                        <a onMouseOver={handleMouseOver} onMouseOut={handleMouseOut} className='text-[#505050] text-[13px] flex items-center py-[4px] pr-[4px] pl-[10px] h-[34px] font-medium gap-4 hover:text-[#fff] ' href="client/src/components/catergory/CategoryProduct">
                            <span><BsLaptop className='text-[20px]' /></span>
                            <span>PC Special</span>
                    </a>
                    </li>
                    <li className='hover:bg-[#ea1c04]  '>
                        <a onMouseOver={handleMouseOver} onMouseOut={handleMouseOut} className='text-[#505050] text-[13px] flex items-center py-[4px] pr-[4px] pl-[10px] h-[34px] font-medium gap-4 hover:text-[#fff] ' href="client/src/components/catergory/CategoryProduct">
                            <span><BsLaptop /></span>
                            <span>PC GEARVN Inter</span>
                    </a>
                    </li>
                    <li className='hover:bg-[#ea1c04]  '>
                        <a onMouseOver={handleMouseOver} onMouseOut={handleMouseOut} className='text-[#505050] text-[13px] flex items-center py-[4px] pr-[4px] pl-[10px] h-[34px] font-medium gap-4 hover:text-[#fff] ' href="client/src/components/catergory/CategoryProduct">
                            <span><BsLaptop /></span>
                            <span>PC GEARVN AMD</span>
                        </a>
                    </li>
                    <li className='hover:bg-[#ea1c04]  '>
                        <a onMouseOver={handleMouseOver} onMouseOut={handleMouseOut} className='text-[#505050] text-[13px] flex items-center py-[4px] pr-[4px] pl-[10px] h-[34px] font-medium gap-4 hover:text-[#fff] ' href="client/src/components/catergory/CategoryProduct">
                        <span><TfiApple className="text-[20px] " /></span>
                            <span>Apple</span>
                    </a>
                    </li>
                    <li className='hover:bg-[#ea1c04]  '>
                        <a onMouseOver={handleMouseOver} onMouseOut={handleMouseOut} className='text-[#505050] text-[13px] flex items-center py-[4px] pr-[4px] pl-[10px] h-[34px] font-medium gap-4 hover:text-[#fff] ' href="client/src/components/catergory/CategoryProduct">
                        <span><BsLaptop /></span>
                            <span>Linh kiện PC</span>
                    </a>
                    </li>
                    <li className='hover:bg-[#ea1c04]  '>
                        <a onMouseOver={handleMouseOver} onMouseOut={handleMouseOut} className='text-[#505050] text-[13px] flex items-center py-[4px] pr-[4px] pl-[10px] h-[34px] font-medium gap-4 hover:text-[#fff] ' href="client/src/components/catergory/CategoryProduct">
                        <span><SlScreenDesktop className='text-[20px] ' /></span>
                            <span>Màn hình</span>
                    </a>
                    </li>
                    <li className='hover:bg-[#ea1c04]  '>
                        <a onMouseOver={handleMouseOver} onMouseOut={handleMouseOut} className='text-[#505050] text-[13px] flex items-center py-[4px] pr-[4px] pl-[10px] h-[34px] font-medium gap-4 hover:text-[#fff] ' href="client/src/components/catergory/CategoryProduct">
                        <span><GiKeyboard className='text-[20px] ' /></span>
                            <span>Bàn phím</span>
                    </a>
                    </li>
                    <li className='hover:bg-[#ea1c04]  '>
                        <a onMouseOver={handleMouseOver} onMouseOut={handleMouseOut} className='text-[#505050] text-[13px] flex items-center py-[4px] pr-[4px] pl-[10px] h-[34px] font-medium gap-4 hover:text-[#fff] ' href="client/src/components/catergory/CategoryProduct">
                        <span><GiMouse className='text-[20px] ' /></span>
                        <span>Chuột + Lót chuột </span>
                        </a>
                    </li>
                    <li className='hover:bg-[#ea1c04]  '>
                        <a onMouseOver={handleMouseOver} onMouseOut={handleMouseOut} className='text-[#505050] text-[13px] flex items-center py-[4px] pr-[4px] pl-[10px] h-[34px] font-medium gap-4 hover:text-[#fff] ' href="client/src/components/catergory/CategoryProduct">
                            <span><BiHeadphone className='text-[20px] ' /></span>
                            <span>Tai nghe - Loa</span>
                        </a>
                    </li>
                    <li className='hover:bg-[#ea1c04]  '>
                        <a onMouseOver={handleMouseOver} onMouseOut={handleMouseOut} className='text-[#505050] text-[13px] flex items-center py-[4px] pr-[4px] pl-[10px] h-[34px] font-medium gap-4 hover:text-[#fff] ' href="client/src/components/catergory/CategoryProduct">
                        <span><BsLaptop className='hover:text-[#333] text-[20px]' /></span>
                        <span>Thiết bị văn phòng</span>
                    </a>
                    </li>
                    <li className='hover:bg-[#ea1c04]  '>
                        <a onMouseOver={handleMouseOver} onMouseOut={handleMouseOut} className='text-[#505050] text-[13px] flex items-center py-[4px] pr-[4px] pl-[10px] h-[34px] font-medium gap-4 hover:text-[#fff] ' href="client/src/components/catergory/CategoryProduct">
                            <span><BsLaptop /></span>
                            <span>Phần mềm & Mạng</span>
                        </a>
                    </li>
                    <li className='hover:bg-[#ea1c04]  '>
                        <a onMouseOver={handleMouseOver} onMouseOut={handleMouseOut} className='text-[#505050] text-[13px] flex items-center py-[4px] pr-[4px] pl-[10px] h-[34px] font-medium gap-4 hover:text-[#fff] ' href="client/src/components/catergory/CategoryProduct">
                            <span><BsLaptop /></span>
                            <span>Phụ kiện</span>
                        </a>
                    </li>


                </ul>

            </div>
        </>
  )
}

export default CategoryProduct

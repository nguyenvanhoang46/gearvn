import React, { useState, useEffect } from 'react'
import { Link, useNavigate, useParams } from "react-router-dom";
import Category from '../catergory'
import Header from '../Header'
import Footer from '../Footer';
import { getProductId } from '../../app/services/adminService';
import "./Tabs.css";

const ProductDetail = () => {

    const { id } = useParams();

    const [data, setData] = useState(null);
    const [toggleState, setToggleState] = useState(1);

    const toggleTab = (index) => {
        setToggleState(index);
    };
    useEffect(() => {
        const getAllProduct = async () => {
            const dataPro = await getProductId(id);
            setData(dataPro);
        }
        getAllProduct();
    }, []);

    console.log(data, "da")


    return (
        <>
            <div className='bg-[#f1f0f1]'>
                <Header />
                <Category />
            </div>

            <div className="container mx-auto ">
                <div className="grid grid-cols-2">
                    <div className="">
                        {/* <img src={data.images.length > 0 ? data.images[0].url : ""} alt="" /> */}
                    </div>
                    <div className=''>
                        <h1 className='py-20px text-[24px] m-0 font-medium  '>{data?.name}</h1>
                        <br />
                        <p><span className='text-[#ff0000] text-[17px] '><u><strong>Quà tặng:</strong></u></span></p>
                        <p className='mt-1'><span className='text-[15px] '><strong>🎁 Túi chống sốc GearVN&nbsp;14"</strong></span></p>
                        <p className='mt-1'><span className='text-[15px] '><strong>🎁 Balo Lenovo Office</strong></span></p>
                        <p className='mt-1'><span className='text-[15px] '><strong>🎁 Chuột Havit MS66GT Black</strong></span></p>
                        <p className='mt-1'><span className='text-[15px] '><strong><a>🎁 Voucher Got It trị giá 200,000đ&nbsp;"SIÊU SALE CUỐI NĂM" (từ 16.12 - 31.12.2022)</a></strong></span></p>
                        <hr className='my-[20px] ' />
                        <p><span className='text-[#ff0000] text-[17px] '><strong><u>ƯU ĐÃI KHI MUA KÈM LAPTOP:</u></strong></span></p>
                        <p>
                            <span className='text-[15px] text-[#428bca] '>

                                ⭐ <Link className='hover:text-[#f45b4f] ' to={"/"}>Mua túi chống sốc chỉ với giá 49.000đ</Link>
                                <br />
                                ⭐ <Link className='hover:text-[#f45b4f] ' to={"/"} >Giảm ngay 100.000đ khi mua kèm Ram Laptop.</Link>
                                <br />
                                ⭐ <Link className='hover:text-[#f45b4f] ' to={"/"} >Giảm đến 200.000đ khi mua kèm Balo, túi chống sốc, phụ kiện.</Link>
                                <br />
                                ⭐ <Link className='hover:text-[#f45b4f] ' to={"/"} >Giảm ngay 30.000đ khi mua Đế tản nhiệt Laptop.</Link>
                                <br />
                                ⭐ Giảm ngay 100.000đ khi mua chuột TUF Gaming M3, Logitech G203, G102.
                            </span>
                        </p>

                        <hr className='my-[20px] ' />
                        <p className='text-[#ff0000] '><strong>Hỗ trợ trả góp MPOS (Thẻ tín dụng), HDSAISON <Link to={"/"}>(<span className='text-[#3498db]'>Xem chi tiết</span>)</Link>.</strong></p>
                        <div className="mt-4">
                            <span className="text-[15px] mr-3 font-medium ">Giá Cũ:</span><span className="text-[#888] text-[20px] "><del>{data?.salePrice}</del></span>
                            <br />
                            <span className="text-[15px] mr-2 font-medium ">Giá KM:</span><span className="text-[#e61010] text-[20px] font-bold ">{data?.price}</span>
                        </div>
                        <div className='mt-3 '>
                            <Link to={"/"} className='bg-[#ed1f24] pt-[3px] pb-[7px] px-[30px] text-[24px] rounded font-bold text-[#fff] '>Đặt hàng</Link>
                        </div>
                    </div>
                </div>
                <div className="tab-container">
                    <div className="bloc-tabs">
                        <button
                            className={toggleState === 1 ? "tabs active-tabs" : "tabs"}
                            onClick={() => toggleTab(1)}
                        >
                            Mô tả sản phẩm
                        </button>
                        <button
                            className={toggleState === 2 ? "tabs active-tabs" : "tabs"}
                            onClick={() => toggleTab(2)}
                        >
                            Đặc điểm nổi bật
                        </button>
                        <button
                            className={toggleState === 3 ? "tabs active-tabs" : "tabs"}
                            onClick={() => toggleTab(3)}
                        >
                            Thông tin bảo hành
                        </button>
                    </div>

                    <div className="content-tabs">
                        <div className={toggleState === 1 ? "content  active-content" : "content"}>
                            <h2 className='text-[20px] mt-4 mb-2'> <strong> Thông số kỹ thuật:</strong></h2>
                            <table>
                                <tbody>
                                    <tr>
                                        <td className='tabs-td'>
                                            <span className="text-[18px]">
                                                <strong><a className='text-[#428bca] hover:text-[#f45b4f]' href="">CPU</a></strong>
                                            </span>
                                        </td>
                                        <td className='tabs-td-right'>
                                            <span className='text-[18px] '><span className="text-[#000000]">Intel® Core™ i5-12500H (2.5GHz~4.5GHz), 12 Cores, 16 Threads (4P + 8E),&nbsp;18 MB Intel® Smart Cache&nbsp;</span></span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td className='tabs-td'>
                                            <span className="text-[18px]">
                                                <strong><a className='text-[#428bca] hover:text-[#f45b4f]' href="">RAM</a></strong>
                                            </span>
                                        </td>
                                        <td className='tabs-td-right'>
                                            <span className='text-[18px] '><span className="text-[#000000]">8GB (1x8GB) <span className='text-[#428bca]'>DDR4</span>-3200Mhz (2 khe ram, nâng cấp tối đa 64GB RAM)</span></span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td className='tabs-td'>
                                            <span className="text-[18px]">
                                                <strong><a className='text-[#428bca] hover:text-[#f45b4f]' href="">Ổ cứng</a></strong>
                                            </span>
                                        </td>
                                        <td className='tabs-td-right'>
                                            <span className='text-[18px] '><span className="text-[#000000]">512GB<span className='text-[#428bca]'>SSD M.2 PCIE</span> G4X4 (2 khe M.2, Còn trống 1 khe SSD M.2 PCIE G3x4)</span></span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td className='tabs-td'>
                                            <span className="text-[18px]">
                                                <strong><a className='text-[#428bca] hover:text-[#f45b4f]' href="">Card đồ họa</a></strong>
                                            </span>
                                        </td>
                                        <td className='tabs-td-right'>
                                            <span className='text-[18px] '><span className="text-[#000000]">NVidia Geforce RTX 3050 4GB GDDR6</span></span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td className='tabs-td'>
                                            <span className="text-[18px]">
                                                <strong><a className='text-[#428bca] hover:text-[#f45b4f]' href="">Màn hình</a></strong>
                                            </span>
                                        </td>
                                        <td className='tabs-td-right'>
                                            <span className='text-[18px] '><span className="text-[#000000]">15.6 inch FHD (1920x1080),  144Hz,  IPS-level, Thin Bezel</span></span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td className='tabs-td'>
                                            <span className="text-[18px]">
                                                <strong><a className='text-[#428bca] hover:text-[#f45b4f]' href="">Bàn phím</a></strong>
                                            </span>
                                        </td>
                                        <td className='tabs-td-right'>
                                            <span className='text-[18px] '><span className="text-[#000000]">Bàn phím fullsize, hỗ trợ LED 15 màu</span></span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td className='tabs-td'>
                                            <span className="text-[18px]">
                                                <strong><a className='hover:text-[#f45b4f]' href="">Chuẩn LAN</a></strong>
                                            </span>
                                        </td>
                                        <td className='tabs-td-right'>
                                            <span className='text-[18px] '><span className="text-[#000000]">RTL8411B REALTEK (1G) Ethernet</span></span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td className='tabs-td'>
                                            <span className="text-[18px]">
                                                <strong><a className='hover:text-[#f45b4f]' href="">Chuẩn WIFI</a></strong>
                                            </span>
                                        </td>
                                        <td className='tabs-td-right'>
                                            <span className='text-[18px] '><span className="text-[#000000]">Intel® Wi-Fi 6</span></span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td className='tabs-td'>
                                            <span className="text-[18px]">
                                                <strong><a className='hover:text-[#f45b4f]' href="">Webcam</a></strong>
                                            </span>
                                        </td>
                                        <td className='tabs-td-right'>
                                            <span className='text-[18px] '><span className="text-[#000000]">HD 720p</span></span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td className='tabs-td'>
                                            <span className="text-[18px]">
                                                <strong><a className='hover:text-[#f45b4f]' href="">Hệ điều hành</a></strong>
                                            </span>
                                        </td>
                                        <td className='tabs-td-right'>
                                            <span className='text-[18px] '>
                                                <span className="text-[#000000]">
                                                    <span className='text-[#428bca]'>Windows 11</span> Home
                                                </span>
                                            </span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td className='tabs-td'>
                                            <span className="text-[18px]">
                                                <strong><a className='hover:text-[#f45b4f]' href="">Pin</a></strong>
                                            </span>
                                        </td>
                                        <td className='tabs-td-right'>
                                            <span className='text-[18px] '><span className="text-[#000000]">Lithium-Ion 54Wh</span></span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td className='tabs-td'>
                                            <span className="text-[18px]">
                                                <strong><a className='hover:text-[#f45b4f]' href="">Trọng lượng</a></strong>
                                            </span>
                                        </td>
                                        <td className='tabs-td-right'>
                                            <span className='text-[18px] '><span className="text-[#000000]">1,9 kg</span></span>
                                        </td>
                                    </tr>

                                </tbody>
                            </table>
                        </div>
                        <div className={toggleState === 2 ? "content  active-content" : "content"}>
                            <h2></h2>
                        </div>

                        <div className={toggleState === 3 ? "content  active-content" : "content"}>
                            <h2></h2>
                        </div>
                    </div>
                </div>
                <div className="mt-20">
                    <Footer />
                </div>
            </div>

        </>
    )
}

export default ProductDetail
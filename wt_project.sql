-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 08, 2018 at 07:12 PM
-- Server version: 10.1.22-MariaDB
-- PHP Version: 7.1.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `wt_project`
--

-- --------------------------------------------------------

--
-- Table structure for table `comments`
--

CREATE TABLE `comments` (
  `comment_id` int(11) NOT NULL,
  `post_id` int(11) NOT NULL,
  `commenter_id` varchar(11) NOT NULL,
  `text` varchar(3000) NOT NULL,
  `time` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `comments`
--

INSERT INTO `comments` (`comment_id`, `post_id`, `commenter_id`, `text`, `time`) VALUES
(67, 61, '1', 'moira ja', '2017-09-10 17:22:34'),
(68, 61, '1', 'bhalo hoyai', '2017-09-10 17:22:39'),
(69, 61, '1', 'jiboneu parbina', '2017-09-11 00:12:07'),
(70, 66, '1', 'wf', '2017-09-12 00:08:17'),
(71, 65, '1', 'fas', '2017-09-12 00:09:47'),
(72, 62, '1', 'gew', '2017-09-12 00:09:57'),
(73, 63, '1', 'we', '2017-09-12 00:10:00'),
(74, 73, '2', 'no time', '2017-09-14 02:11:27'),
(75, 73, '2', 'not ime', '2017-09-14 06:13:18'),
(76, 73, '2', 'nnn', '2017-09-14 06:16:16'),
(77, 73, '2', 'te', '2017-09-14 06:26:54'),
(78, 73, '2', 'wr', '2017-09-14 06:28:26'),
(79, 88, '1', 'good', '2017-09-16 15:02:49'),
(80, 88, '1', 'yo', '2017-09-16 16:16:14'),
(81, 88, '1', 'gg', '2017-09-16 16:16:23'),
(82, 88, '1', 'vas', '2017-09-17 02:40:39'),
(83, 88, '1', 'vas', '2017-09-17 02:41:21'),
(84, 87, '1', 'no', '2017-09-17 02:44:52'),
(85, 87, '1', 'yes', '2017-09-17 02:45:22'),
(86, 87, '1', 'tt', '2017-09-17 02:45:43'),
(87, 87, '1', 'ews', '2017-09-17 02:48:09'),
(88, 86, '1', 'good', '2017-09-17 02:48:55'),
(89, 86, '1', 'bad', '2017-09-17 02:48:58'),
(90, 86, '1', 'hr', '2017-09-17 02:51:00'),
(91, 86, '1', 'vv', '2017-09-17 02:51:03'),
(92, 87, '1', 'weq', '2017-09-17 02:51:23'),
(93, 87, '1', 'weqr', '2017-09-17 02:51:24'),
(94, 87, '1', 'weqrq', '2017-09-17 02:51:26'),
(95, 89, '1', 'fas', '2017-09-18 13:33:35'),
(96, 89, '4', 'jh', '2017-09-19 21:11:00'),
(97, 90, '1', 'ok', '2017-09-20 13:56:15'),
(98, 90, '2', 'gg', '2017-09-20 13:56:30');

-- --------------------------------------------------------

--
-- Table structure for table `confirmation`
--

CREATE TABLE `confirmation` (
  `user_id` varchar(11) NOT NULL,
  `status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `confirmation`
--

INSERT INTO `confirmation` (`user_id`, `status`) VALUES
('1', 'notconfirmed');

-- --------------------------------------------------------

--
-- Table structure for table `courses`
--

CREATE TABLE `courses` (
  `course_id` int(11) NOT NULL,
  `course_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `courses`
--

INSERT INTO `courses` (`course_id`, `course_name`) VALUES
(1, 'Web Tech'),
(2, 'Computer Networks'),
(3, 'PL1'),
(4, 'OS'),
(5, 'SE'),
(6, 'PL2'),
(8, 'History'),
(9, 'DB');

-- --------------------------------------------------------

--
-- Table structure for table `inbox`
--

CREATE TABLE `inbox` (
  `msg_id` int(11) NOT NULL,
  `text` varchar(500) NOT NULL,
  `time` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `sender_id` varchar(11) NOT NULL,
  `receiver_id` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `inbox`
--

INSERT INTO `inbox` (`msg_id`, `text`, `time`, `sender_id`, `receiver_id`) VALUES
(51, 'tons left to do', '2017-09-13 04:57:00', '3', '1'),
(52, 'whays pop', '2017-09-14 05:46:02', '1', '3'),
(53, 'hola', '2017-09-14 05:46:53', '1', '2'),
(54, 'k', '2017-09-14 06:04:11', '1', '2'),
(55, 'ok', '2017-09-14 06:06:24', '2', '1'),
(56, 'casd', '2017-09-15 01:59:56', '1', '3'),
(57, 'hola', '2017-09-16 15:27:55', '1', '2'),
(58, 'fas', '2017-09-16 16:00:02', '1', '2'),
(59, 'geasd', '2017-09-16 16:24:52', '1', '3'),
(60, 'vea', '2017-09-16 16:25:05', '1', '2'),
(61, 'vas', '2017-09-16 21:14:20', '1', '3'),
(62, 'er', '2017-09-17 00:14:25', '1', '3'),
(63, 'vas', '2017-09-17 01:53:50', '1', '3'),
(64, 'a', '2017-09-17 01:53:51', '1', '3'),
(65, 'a', '2017-09-17 01:53:52', '1', '3'),
(66, 'a', '2017-09-17 01:53:53', '1', '3'),
(67, 'a', '2017-09-17 01:53:54', '1', '3'),
(68, 'a', '2017-09-17 01:53:56', '1', '3'),
(69, 'a', '2017-09-17 01:53:57', '1', '3'),
(70, 'a', '2017-09-17 01:53:58', '1', '3'),
(71, 'ewr', '2017-09-18 15:45:32', '1', '3'),
(72, 'ok', '2017-09-20 16:08:27', '1', '2'),
(73, 'asd', '2017-09-20 16:13:04', '2', '1');

-- --------------------------------------------------------

--
-- Table structure for table `posts`
--

CREATE TABLE `posts` (
  `post_id` int(11) NOT NULL,
  `user_id` varchar(11) NOT NULL,
  `course_name` varchar(50) NOT NULL,
  `section` varchar(3) NOT NULL,
  `text` varchar(3000) DEFAULT NULL,
  `file` varchar(3000) DEFAULT NULL,
  `photo` varchar(3000) DEFAULT NULL,
  `time` datetime DEFAULT CURRENT_TIMESTAMP,
  `filename` varchar(200) NOT NULL,
  `photoname` varchar(200) NOT NULL,
  `reg_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `posts`
--

INSERT INTO `posts` (`post_id`, `user_id`, `course_name`, `section`, `text`, `file`, `photo`, `time`, `filename`, `photoname`, `reg_id`) VALUES
(49, '3', 'Computer Networks', 'B', 'do you like it?', '', '5992d7b558ad6.jpg', '2017-08-15 13:15:01', '', 'FB_IMG_1485055071372.jpg', 0),
(52, '1', 'Web Tech', 'A', 'with sec', '', '', '2017-08-15 19:22:45', '', '', 0),
(53, '3', 'PL1', 'A', 'mazed post with sec', '59932f3d40553.uxf', '', '2017-08-15 19:28:29', '2nd-sequence-diagram.uxf', '', 0),
(54, '3', 'PL1', 'A', 'is this ok?', '59932f95d6588.txt', '', '2017-08-15 19:29:57', '1to9cmp.txt', '', 0),
(55, '2', 'Web Tech', 'A', 'ss', '', '', '2017-08-15 19:37:35', '', '', 0),
(56, '2', 'Web Tech', 'A', 'thr post', '', '', '2017-08-15 21:02:12', '', '', 0),
(57, '3', 'Web Tech', 'A', 'hahahahaha', '59934ab0c5bd1.php', '', '2017-08-15 21:25:36', 'user.php', '', 0),
(58, '3', 'Web Tech', 'A', '', '', '59934b49466c0.jpg', '2017-08-15 21:28:09', '', 'WWW.YTS.AG.jpg', 0),
(59, '1', 'Computer Networks', 'B', 'post', '5993f393b86ac.srt', '5993f393b8412.jpg', '2017-08-16 09:26:11', 'Doctor.Strange.2016.720p.HC.HDRip.950MB.MkvCage.srt', 'M2.jpg', 0),
(60, '2', 'Web Tech', 'A', 'ff', '', '', '2017-08-16 13:12:54', '', '', 0),
(61, '1', 'Computer Networks', 'B', 'eta keu sove dite parben\"?', '59a3fce1bbb65.jpg', '', '2017-08-28 13:22:09', 'fff.JPG', '', 0),
(62, '1', 'Web Tech', 'A', 'fqw', '', '', '2017-09-10 21:49:50', '', '', 0),
(63, '3', 'Web Tech', 'A', 'fas', '', '', '2017-09-10 22:50:46', '', '', 0),
(64, '3', 'Web Tech', 'A', 'fas', '', '', '2017-09-10 22:50:48', '', '', 0),
(65, '3', 'Web Tech', 'A', 'fas', '', '', '2017-09-10 22:51:03', '', '', 0),
(66, '3', 'Web Tech', 'A', 'this', '', '', '2017-09-10 22:54:57', '', '', 0),
(67, '1', 'Web Tech', 'A', 'fasd', '', '', '2017-09-12 15:40:43', '', '', 0),
(68, '1', 'Web Tech', 'A', '', '', '59b7e3ecc0e9a.jpg', '2017-09-12 15:41:00', '', 'B612_20161221_230452.jpg', 0),
(69, '1', 'Computer Networks', 'B', '', '', '59b7e3fc3f443.jpg', '2017-09-12 15:41:16', '', 'B612_20161221_230505.jpg', 0),
(70, '1', 'Web Tech', 'A', 'going', '', '', '2017-09-12 15:41:34', '', '', 0),
(71, '1', 'Web Tech', 'A', 'going to', '', '', '2017-09-12 15:41:42', '', '', 0),
(72, '1', 'Web Tech', 'A', 'going to coxs bazar', '', '59b7e427886a9.jpg', '2017-09-12 15:41:59', '', 'B612_20161221_230452.jpg', 0),
(73, '2', 'Web Tech', 'A', 'no time', '', '', '2017-09-14 06:11:17', '', '', 0),
(76, '1', 'Web Tech', 'A', 'new post', '', '', '2017-09-16 14:26:08', '', '', 0),
(77, '1', 'Web Tech', 'A', 'thisss', '59bce0373a56e.jpg', '59bce0373a139.jpg', '2017-09-16 14:26:31', 'ins.JPG', 'acc.JPG', 0),
(79, '1', 'Web Tech', 'A', '', '', '59bce0e892e79.jpg', '2017-09-16 14:29:28', '', 'ru-crop.JPG', 0),
(80, '1', 'Web Tech', 'A', '', '59bce0f20a795.jpg', '', '2017-09-16 14:29:38', 'ru.JPG', '', 0),
(81, '1', 'Web Tech', 'A', 'ggg', '59bce16377cae.jpg', '59bce1637783c.jpg', '2017-09-16 14:31:31', 'ai.JPG', 'ai.JPG', 0),
(85, '1', 'Web Tech', 'A', '', '59bce1be371c2.jpg', '', '2017-09-16 14:33:02', 'cr.JPG', '', 0),
(86, '1', 'Web Tech', 'A', '', '', '59bce1de737dc.jpg', '2017-09-16 14:33:34', '', 'Capture.JPG', 0),
(87, '1', 'Web Tech', 'A', '', '59bce1e23a512.jpg', '', '2017-09-16 14:33:38', 'ai.JPG', '', 0),
(88, '1', 'Web Tech', 'A', 'asda', '59bce1ececa2d.jpg', '59bce1ecec816.jpg', '2017-09-16 14:33:48', 'rb.JPG', 'rb.JPG', 0),
(89, '2', 'Web Tech', 'A', 'this post', '59bf7361a356b.jpg', '59bf7361a335b.jpg', '2017-09-18 13:18:57', 'fff.JPG', 'acc.JPG', 0),
(90, '4', 'SE', 'C', 'this new post ', '', '', '2017-09-20 13:55:48', '', '', 0),
(91, '2', 'SE', 'C', 'vsa', '', '', '2017-09-20 13:58:11', '', '', 0),
(92, '1', 'History', 'S', 'his', '', '', '2017-09-20 13:58:30', '', '', 0),
(93, '2', 'SE', 'C', 'new new new', '59c21fd17e3ed.jpg', '59c21fd17e185.jpg', '2017-09-20 13:59:13', 'rr.jpg', 'rr.jpg', 0),
(94, '1', 'OS', 'A', 'ww', '', '', '2017-09-20 14:48:02', '', '', 0),
(95, '1', 'OS', 'A', 'fasd', '', '59c23efec57cd.jpg', '2017-09-20 16:12:14', '', '17835216_1641417935886461_8910525416897357375_o.jpg', 0);

-- --------------------------------------------------------

--
-- Table structure for table `registration`
--

CREATE TABLE `registration` (
  `user_id` varchar(11) NOT NULL,
  `course_id` int(11) NOT NULL,
  `course_name` varchar(50) NOT NULL,
  `section` varchar(3) NOT NULL,
  `grade` varchar(3) NOT NULL,
  `reg_id` int(11) NOT NULL,
  `status` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `registration`
--

INSERT INTO `registration` (`user_id`, `course_id`, `course_name`, `section`, `grade`, `reg_id`, `status`) VALUES
('1', 1, 'Web Tech', 'A', 'C', 0, 'confirmed'),
('1', 2, 'Computer Networks', 'A', '', 0, ''),
('1', 2, 'Computer Networks', 'A', 'C', 1, 'confirmed'),
('1', 3, 'PL1', 'A', '', 1, 'confirmed'),
('1', 4, 'OS', 'A', '', 9, 'confirmed'),
('1', 5, 'SE', 'C', '', 10, 'confirmed'),
('1', 8, 'History', 'S', 'A', 8, 'confirmed'),
('2', 1, 'Web Tech', 'A', 'B', 0, 'confirmed'),
('2', 2, 'Computer Networks', 'A', 'A', 1, 'confirmed'),
('2', 4, 'OS', 'A', '', 9, 'confirmed'),
('2', 5, 'SE', 'C', 'A ', 8, 'confirmed'),
('3', 1, 'Web Tech', 'A', 'X', 0, 'confirmed'),
('3', 3, 'PL1', 'A', '', 0, 'confirmed'),
('4', 1, 'Web Tech', 'A', '', 0, 'confirmed'),
('4', 2, 'Computer Networks', 'A', '', 0, 'confirmed'),
('4', 2, 'Computer Networks', 'A', '', 1, 'confirmed'),
('4', 3, 'PL1', 'A', '', 0, 'confirmed'),
('4', 5, 'SE', 'C', '', 8, 'confirmed'),
('4', 8, 'History', 'S', '', 8, 'confirmed');

-- --------------------------------------------------------

--
-- Table structure for table `sections`
--

CREATE TABLE `sections` (
  `course_id` int(11) NOT NULL,
  `section` varchar(3) NOT NULL,
  `capacity` int(11) NOT NULL DEFAULT '40',
  `count` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sections`
--

INSERT INTO `sections` (`course_id`, `section`, `capacity`, `count`) VALUES
(1, 'A', 40, 0),
(1, 'B', 40, 0),
(1, 'C', 40, 0),
(2, 'A', 40, 0),
(2, 'B', 40, 0),
(3, 'A', 40, 0),
(4, 'A', 40, 0),
(5, 'C', 40, 0),
(6, 'A', 40, 0),
(8, 'S', 40, 0),
(9, 'E', 40, 0);

-- --------------------------------------------------------

--
-- Table structure for table `semesters`
--

CREATE TABLE `semesters` (
  `sem_id` int(11) NOT NULL,
  `sem_name` varchar(20) NOT NULL,
  `status` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `semesters`
--

INSERT INTO `semesters` (`sem_id`, `sem_name`, `status`) VALUES
(0, '2016-17 Summer', 'closed'),
(1, '2016-17 Fall', 'closed'),
(5, '2017-18 summer', 'closed'),
(6, 'this', 'closed'),
(7, 'new2', 'closed'),
(8, '2017-18 Spring', 'closed'),
(9, '2017-18 Fall', 'closed'),
(10, '2018-19 Spring', 'closed'),
(11, '2018 Summer', 'open');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` varchar(10) NOT NULL,
  `password` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `password`) VALUES
('1', '123456');

-- --------------------------------------------------------

--
-- Table structure for table `user_info`
--

CREATE TABLE `user_info` (
  `user_id` varchar(11) NOT NULL,
  `name` varchar(20) DEFAULT NULL,
  `photo` varchar(500) NOT NULL,
  `type` varchar(10) NOT NULL,
  `email` varchar(20) DEFAULT NULL,
  `status` varchar(10) DEFAULT NULL,
  `started` date DEFAULT NULL,
  `finished` date DEFAULT NULL,
  `password` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user_info`
--

INSERT INTO `user_info` (`user_id`, `name`, `photo`, `type`, `email`, `status`, `started`, `finished`, `password`) VALUES
('', 'raf', 'das.jpg', 'student', 'dsf@gmail.com', 'ongoing', NULL, NULL, '489'),
('1', 'Rafin Utshaw', 'guy.jpg', 'student', 'utshaw00@gmail.com', 'ongoing', NULL, NULL, 'wer'),
('2', 'Mansib Mahbub', '', 'student', 'mansib@gmail.com', 'ongoing', NULL, NULL, '456'),
('234', 'fds e', '', 'student', 're@gmail.com', 'ongoing', NULL, NULL, '435'),
('3', 'Mazed', '', 'student', 'mazed@gamil.com', 'Ongoing', NULL, NULL, '789'),
('4', 'Shuvro', '', 'teacher', 'shuvro@gmail.com', 'ongoing', NULL, NULL, '4'),
('59', 'tahla isoam', '59bf5c8ac52a8.jpg', 'student', 're@gmail.com', 'ongoing', NULL, NULL, '5810'),
('78', 'sd', '59bf5894db57c.jpg', 'student', 're@gmail.com', 'ongoing', NULL, NULL, '5810'),
('8', 'blah', '', 'student', 'stu@gmaul.com', 'ongoing', NULL, NULL, 'blah'),
('9', 'gef', 'ves', 'fasd', 'gsdfds', 'fsgb', NULL, NULL, '345'),
('admin', 'admin', '', 'admin', NULL, NULL, NULL, NULL, 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `user_semesters`
--

CREATE TABLE `user_semesters` (
  `sem_id` int(11) NOT NULL,
  `status` varchar(15) NOT NULL,
  `user_id` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user_semesters`
--

INSERT INTO `user_semesters` (`sem_id`, `status`, `user_id`) VALUES
(1, 'confirmed', '1'),
(0, 'confirmed', '1'),
(0, 'this', '2'),
(6, 'notconfirmed', '2'),
(8, 'notconfirmed', ''),
(8, 'confirmed', '1'),
(8, 'confirmed', '2'),
(8, 'notconfirmed', '234'),
(8, 'notconfirmed', '3'),
(8, 'confirmed', '4'),
(8, 'notconfirmed', '59'),
(8, 'notconfirmed', '78'),
(8, 'notconfirmed', '8'),
(8, 'notconfirmed', '9'),
(8, 'notconfirmed', 'admin'),
(9, 'notconfirmed', ''),
(9, 'confirmed', '1'),
(9, 'confirmed', '2'),
(9, 'notconfirmed', '234'),
(9, 'notconfirmed', '3'),
(9, 'notconfirmed', '4'),
(9, 'notconfirmed', '59'),
(9, 'notconfirmed', '78'),
(9, 'notconfirmed', '8'),
(9, 'notconfirmed', '9'),
(9, 'notconfirmed', 'admin'),
(10, 'notconfirmed', ''),
(10, 'confirmed', '1'),
(10, 'notconfirmed', '2'),
(10, 'notconfirmed', '234'),
(10, 'notconfirmed', '3'),
(10, 'notconfirmed', '4'),
(10, 'notconfirmed', '59'),
(10, 'notconfirmed', '78'),
(10, 'notconfirmed', '8'),
(10, 'notconfirmed', '9'),
(10, 'notconfirmed', 'admin'),
(11, 'notconfirmed', ''),
(11, 'notconfirmed', '1'),
(11, 'notconfirmed', '2'),
(11, 'notconfirmed', '234'),
(11, 'notconfirmed', '3'),
(11, 'notconfirmed', '4'),
(11, 'notconfirmed', '59'),
(11, 'notconfirmed', '78'),
(11, 'notconfirmed', '8'),
(11, 'notconfirmed', '9'),
(11, 'notconfirmed', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `comments`
--
ALTER TABLE `comments`
  ADD PRIMARY KEY (`comment_id`),
  ADD KEY `comments_posts_fk` (`post_id`),
  ADD KEY `comments_users_info_fk` (`commenter_id`);

--
-- Indexes for table `courses`
--
ALTER TABLE `courses`
  ADD PRIMARY KEY (`course_id`,`course_name`);

--
-- Indexes for table `inbox`
--
ALTER TABLE `inbox`
  ADD PRIMARY KEY (`msg_id`),
  ADD KEY `sender_id_user_id_fk` (`sender_id`),
  ADD KEY `receiver_id_user_id_fk` (`receiver_id`);

--
-- Indexes for table `posts`
--
ALTER TABLE `posts`
  ADD PRIMARY KEY (`post_id`,`user_id`),
  ADD KEY `posts_user_info_fk` (`user_id`),
  ADD KEY `semesters_posts_fk` (`reg_id`);

--
-- Indexes for table `registration`
--
ALTER TABLE `registration`
  ADD PRIMARY KEY (`user_id`,`course_id`,`reg_id`) USING BTREE,
  ADD KEY `registration_sections_fk` (`course_id`,`section`),
  ADD KEY `registration_courses_fk` (`course_id`,`course_name`),
  ADD KEY `reg_id_sem_id_fk` (`reg_id`);

--
-- Indexes for table `sections`
--
ALTER TABLE `sections`
  ADD PRIMARY KEY (`course_id`,`section`);

--
-- Indexes for table `semesters`
--
ALTER TABLE `semesters`
  ADD PRIMARY KEY (`sem_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `user_info`
--
ALTER TABLE `user_info`
  ADD PRIMARY KEY (`user_id`);

--
-- Indexes for table `user_semesters`
--
ALTER TABLE `user_semesters`
  ADD KEY `user_semesters_semesters_fk` (`sem_id`),
  ADD KEY `user_semesters_user_info_fk` (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `comments`
--
ALTER TABLE `comments`
  MODIFY `comment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=99;
--
-- AUTO_INCREMENT for table `courses`
--
ALTER TABLE `courses`
  MODIFY `course_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `inbox`
--
ALTER TABLE `inbox`
  MODIFY `msg_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=74;
--
-- AUTO_INCREMENT for table `posts`
--
ALTER TABLE `posts`
  MODIFY `post_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=96;
--
-- AUTO_INCREMENT for table `semesters`
--
ALTER TABLE `semesters`
  MODIFY `sem_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `comments`
--
ALTER TABLE `comments`
  ADD CONSTRAINT `comments_posts_fk` FOREIGN KEY (`post_id`) REFERENCES `posts` (`post_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `comments_users_info_fk` FOREIGN KEY (`commenter_id`) REFERENCES `user_info` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `inbox`
--
ALTER TABLE `inbox`
  ADD CONSTRAINT `receiver_id_user_id_fk` FOREIGN KEY (`receiver_id`) REFERENCES `user_info` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `sender_id_user_id_fk` FOREIGN KEY (`sender_id`) REFERENCES `user_info` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `posts`
--
ALTER TABLE `posts`
  ADD CONSTRAINT `posts_user_info_fk` FOREIGN KEY (`user_id`) REFERENCES `user_info` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `semesters_posts_fk` FOREIGN KEY (`reg_id`) REFERENCES `semesters` (`sem_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `registration`
--
ALTER TABLE `registration`
  ADD CONSTRAINT `reg_id_sem_id_fk` FOREIGN KEY (`reg_id`) REFERENCES `semesters` (`sem_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `registration_courses_fk` FOREIGN KEY (`course_id`,`course_name`) REFERENCES `courses` (`course_id`, `course_name`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `registration_sections_fk` FOREIGN KEY (`course_id`,`section`) REFERENCES `sections` (`course_id`, `section`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `registration_user_info_fk` FOREIGN KEY (`user_id`) REFERENCES `user_info` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `sections`
--
ALTER TABLE `sections`
  ADD CONSTRAINT `sections_courses_fk` FOREIGN KEY (`course_id`) REFERENCES `courses` (`course_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `user_user_info_fk` FOREIGN KEY (`user_id`) REFERENCES `user_info` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `user_semesters`
--
ALTER TABLE `user_semesters`
  ADD CONSTRAINT `user_semesters_semesters_fk` FOREIGN KEY (`sem_id`) REFERENCES `semesters` (`sem_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `user_semesters_user_info_fk` FOREIGN KEY (`user_id`) REFERENCES `user_info` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
